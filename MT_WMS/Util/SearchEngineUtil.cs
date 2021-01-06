using Lucene.Net.QueryParsers;
using Lucene.Net.Search;
using Lucene.Net.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanGu;
using System.IO;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using System.Reflection;
using PanGu.HighLight;
using Lucene.Net.Analysis.PanGu;
namespace MT_WMS
{
    /// <summary>
    /// Lucene搜索引擎工具类
    /// Lucene.Net和盘古分词器
    /// </summary>
    public class SearchEngineUtil
    {
        /// <summary>
        /// 创建并添加索引记录
        /// </summary>
        /// <typeparam name="TIndex"></typeparam>
        /// <param name="indexDir"></param>
        /// <param name="indexData"></param>
        /// <param name="setDocFiledsAction"></param>
        public static void AddIndex<TIndex>(string indexDir, TIndex indexData, Action<Document, TIndex> setDocFiledsAction)
        {
            //创建索引目录
            if (!System.IO.Directory.Exists(indexDir))
            {
                System.IO.Directory.CreateDirectory(indexDir);
            }
            FSDirectory directory = FSDirectory.Open(new DirectoryInfo(indexDir), new NativeFSLockFactory());
            bool isUpdate = IndexReader.IndexExists(directory);
            if (isUpdate)
            {
                //如果索引目录被锁定（比如索引过程中程序异常退出），则首先解锁
                if (IndexWriter.IsLocked(directory))
                {
                    IndexWriter.Unlock(directory);
                }
            }
            using (IndexWriter writer = new IndexWriter(directory, new PanGuAnalyzer(), !isUpdate, IndexWriter.MaxFieldLength.UNLIMITED))
            {
                Document document = new Document();

                setDocFiledsAction(document, indexData);

                writer.AddDocument(document);

                writer.Optimize();//优化索引
            }
        }

        /// <summary>
        /// 删除索引记录
        /// </summary>
        /// <param name="indexDir"></param>
        /// <param name="keyFiledName"></param>
        /// <param name="keyFileValue"></param>
        public static void DeleteIndex(string indexDir, string keyFiledName, object keyFileValue)
        {
            FSDirectory directory = FSDirectory.Open(new DirectoryInfo(indexDir), new NativeFSLockFactory());
            if (!IndexReader.IndexExists(directory))
            {
                return;
            }

            using (IndexWriter iw = new IndexWriter(directory, new PanGuAnalyzer(), IndexWriter.MaxFieldLength.UNLIMITED))
            {
                iw.DeleteDocuments(new Term(keyFiledName, keyFileValue.ToString()));
                iw.Optimize();//删除文件后并非从磁盘中移除，而是生成一个.del的文件，需要调用Optimize方法来清除。在清除文件前可以使用UndeleteAll方法恢复
            }
        }

        /// <summary>
        /// 更新索引记录
        /// </summary>
        /// <param name="indexDir"></param>
        /// <param name="keyFiledName"></param>
        /// <param name="keyFileValue"></param>
        /// <param name="doc"></param>
        public static void UpdateIndex(string indexDir, string keyFiledName, object keyFileValue, Document doc)
        {
            FSDirectory directory = FSDirectory.Open(new DirectoryInfo(indexDir), new NativeFSLockFactory());
            if (!IndexReader.IndexExists(directory))
            {
                return;
            }

            using (IndexWriter iw = new IndexWriter(directory, new PanGuAnalyzer(), IndexWriter.MaxFieldLength.UNLIMITED))
            {
                iw.UpdateDocument(new Term(keyFiledName, keyFileValue.ToString()), doc);
                iw.Optimize();
            }
        }

        /// <summary>
        /// 是否存在指定的索引文档
        /// </summary>
        /// <param name="indexDir"></param>
        /// <param name="keyFiledName"></param>
        /// <param name="keyFileValue"></param>
        /// <returns></returns>
        public static bool ExistsDocument(string indexDir, string keyFiledName, object keyFileValue)
        {
            FSDirectory directory = FSDirectory.Open(new DirectoryInfo(indexDir), new NativeFSLockFactory());
            if (!IndexReader.IndexExists(directory))
            {
                return false;
            }

            var reader = IndexReader.Open(directory, true);

            return reader.DocFreq(new Term(keyFiledName, keyFileValue.ToString())) > 0;
        }

        /// <summary>
        /// 查询索引匹配到的记录
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="indexDir"></param>
        /// <param name="buildQueryAction"></param>
        /// <param name="getSortFieldsFunc"></param>
        /// <param name="buildResultFunc"></param>
        /// <param name="topCount"></param>
        /// <param name="needHighlight"></param>
        /// <returns></returns>
        public static List<TResult> SearchIndex<TResult>(string indexDir, Func<BooleanQuery, IDictionary<string, string>> buildQueryAction,
            Func<IEnumerable<SortField>> getSortFieldsFunc, Func<Document, TResult> buildResultFunc, bool needHighlight = true, int topCount = 0)
        {
            FSDirectory directory = FSDirectory.Open(new DirectoryInfo(indexDir), new NoLockFactory());

            if (!IndexReader.IndexExists(directory))
            {
                return new List<TResult>();
            }

            IndexReader reader = IndexReader.Open(directory, true);
            IndexSearcher searcher = new IndexSearcher(reader);

            BooleanQuery bQuery = new BooleanQuery();
            var keyWords = buildQueryAction(bQuery);

            Sort sort = null;
            var sortFields = getSortFieldsFunc();
            if (sortFields != null)
            {
                sort = new Sort();
                sort.SetSort(sortFields.ToArray());
            }

            topCount = topCount > 0 ? topCount : int.MaxValue;//当未指定TOP值，则设置最大值以表示获取全部
            TopDocs resultDocs = null;
            if (sort != null)
            {
                resultDocs = searcher.Search(bQuery, null, topCount, sort);
            }
            else
            {
                resultDocs = searcher.Search(bQuery, null, topCount);
            }

            if (topCount > resultDocs.TotalHits)
            {
                topCount = resultDocs.TotalHits;
            }

            Dictionary<string, PropertyInfo> highlightProps = null;
            List<TResult> results = new List<TResult>();
            if (resultDocs != null)
            {
                for (int i = 0; i < topCount; i++)
                {
                    Document doc = searcher.Doc(resultDocs.ScoreDocs[i].Doc);
                    var model = buildResultFunc(doc);
                    if (needHighlight)
                    {
                        model = SetHighlighter(keyWords, model, ref highlightProps);
                    }

                    results.Add(model);
                }
            }

            return results;

        }

        /// <summary>
        /// 分页查询索引匹配到的记录
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="indexDir"></param>
        /// <param name="buildQueryAction"></param>
        /// <param name="getSortFieldsFunc"></param>
        /// <param name="buildResultFunc"></param>
        /// <param name="pageSize"></param>
        /// <param name="page"></param>
        /// <param name="totalCount"></param>
        /// <param name="needHighlight"></param>
        /// <returns></returns>
        public static List<TResult> SearchIndexByPage<TResult>(string indexDir, Func<BooleanQuery, IDictionary<string, string>> buildQueryAction,
            Func<IEnumerable<SortField>> getSortFieldsFunc, Func<Document, TResult> buildResultFunc, int pageSize, int page, out int totalCount, bool needHighlight = true)
        {
            FSDirectory directory = FSDirectory.Open(new DirectoryInfo(indexDir), new NoLockFactory());

            if (!IndexReader.IndexExists(directory))
            {
                totalCount = 0;
                return new List<TResult>();
            }

            IndexReader reader = IndexReader.Open(directory, true);
            IndexSearcher searcher = new IndexSearcher(reader);

            BooleanQuery bQuery = new BooleanQuery();
            var keyWords = buildQueryAction(bQuery);

            Sort sort = null;
            var sortFields = getSortFieldsFunc();
            if (sortFields != null)
            {
                sort = new Sort();
                sort.SetSort(sortFields.ToArray());
            }

            TopScoreDocCollector docCollector = TopScoreDocCollector.Create(1, true);
            searcher.Search(bQuery, docCollector);
            totalCount = docCollector.TotalHits;

            if (totalCount <= 0) return null;

            TopDocs resultDocs = searcher.Search(bQuery, null, pageSize * page, sort);

            Dictionary<string, PropertyInfo> highlightProps = null;
            List<TResult> results = new List<TResult>();
            int indexStart = (page - 1) * pageSize;
            int indexEnd = indexStart + pageSize;
            if (totalCount < indexEnd) indexEnd = totalCount;

            if (resultDocs != null)
            {
                for (int i = indexStart; i < indexEnd; i++)
                {
                    Document doc = searcher.Doc(resultDocs.ScoreDocs[i].Doc);
                    var model = buildResultFunc(doc);
                    if (needHighlight)
                    {
                        model = SetHighlighter(keyWords, model, ref highlightProps);
                    }

                    results.Add(model);
                }
            }

            return results;
        }



        /// <summary>
        /// 设置结果高亮
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dicKeywords"></param>
        /// <param name="model"></param>
        /// <param name="props"></param>
        /// <returns></returns>
        private static T SetHighlighter<T>(IDictionary<string, string> dicKeywords, T model, ref Dictionary<string, PropertyInfo> props)
        {
            SimpleHTMLFormatter simpleHTMLFormatter = new SimpleHTMLFormatter("<font color=\"red\">", "</font>");
            Highlighter highlighter = new Highlighter(simpleHTMLFormatter, new Segment());
            highlighter.FragmentSize = 250;

            Type modelType = typeof(T);
            foreach (var item in dicKeywords)
            {
                if (!string.IsNullOrWhiteSpace(item.Value))
                {
                    if (props == null)
                    {
                        props = new Dictionary<string, PropertyInfo>();
                    }

                    if (!props.ContainsKey(item.Key))
                    {
                        props[item.Key] = modelType.GetProperty(item.Key, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    }

                    var modelProp = props[item.Key];
                    if (modelProp.PropertyType == typeof(string))
                    {
                        string newValue = highlighter.GetBestFragment(item.Value, modelProp.GetValue(model).ToString());
                        if (!string.IsNullOrEmpty(newValue))
                        {
                            modelProp.SetValue(model, newValue);
                        }
                    }
                }
            }

            return model;
        }


        /// <summary>
        /// 拆分关键词
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public static string GetKeyWordsSplitBySpace(string keyword)
        {
            PanGuTokenizer ktTokenizer = new PanGuTokenizer();
            StringBuilder result = new StringBuilder();
            ICollection<WordInfo> words = ktTokenizer.SegmentToWordInfos(keyword);
            foreach (WordInfo word in words)
            {
                if (word == null)
                {
                    continue;
                }
                result.AppendFormat("{0}^{1}.0 ", word.Word, (int)Math.Pow(3, word.Rank));
            }
            return result.ToString().Trim();
        }

        /// <summary>
        /// 【辅助方法】创建盘古查询对象
        /// </summary>
        /// <param name="field"></param>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public static Query CreatePanGuQuery(string field, string keyword, bool needSplit = true)
        {
            if (needSplit)
            {
                keyword = GetKeyWordsSplitBySpace(keyword);
            }

            QueryParser parse = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, field, new PanGuAnalyzer());
            parse.DefaultOperator = QueryParser.Operator.OR;
            Query query = parse.Parse(keyword);
            return query;
        }

        /// <summary>
        /// 【辅助方法】创建盘古多字段查询对象
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="fields"></param>
        /// <returns></returns>
        public static Query CreatePanGuMultiFieldQuery(string keyword, bool needSplit, params string[] fields)
        {
            if (needSplit)
            {
                keyword = GetKeyWordsSplitBySpace(keyword);
            }

            QueryParser parse = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30, fields, new PanGuAnalyzer());
            parse.DefaultOperator = QueryParser.Operator.OR;
            Query query = parse.Parse(keyword);
            return query;
        }
    }
}

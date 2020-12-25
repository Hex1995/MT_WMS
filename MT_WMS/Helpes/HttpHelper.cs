using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS
{
    /// <summary>
    /// 网络请求类
    /// </summary>
    public class HttpHelper
    {

        /// <summary>
        /// 获取网络数据
        /// </summary>
        /// <param name="url">链接</param>
        /// <param name="dic">Get请求参数</param>
        /// <param name="Parameter">序列化后的对象</param>
        /// <param name="HttpMethod">GET或者POST</param>
        /// <param name="Header">请求头</param>
        /// <returns></returns>
        public static string HttpData(string url, string HttpMethod = "GET", Dictionary<string, string> dic = null, string Parameter = "",  List<string> Header = null)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            if (!dic.IsNullOrEmpty())
            {
                builder.Append("?");
                int i = 0;
                foreach (var item in dic)
                {
                    if (i > 0)
                        builder.Append("&");
                    builder.AppendFormat("{0}={1}", item.Key, item.Value);
                    i++;
                }
            }
            var client = new RestClient(builder.ToString());
            client.Timeout = -1;
            RestRequest request;
            if (HttpMethod.ToUpper()=="GET")
                request = new RestRequest(Method.GET);
            else
                request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", Parameter, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }


        public static string Test()
        {
            var client = new RestClient("http://localhost/MT/api/Product/GetProducts");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "[\r\n    \"ProductName like'%测试%'\"\r\n]", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
        /// <summary>
        /// Get请求
        /// </summary>
        /// <param name="url">请求Url</param>
        /// <returns></returns>
        public static string Get(string url)
        {

            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                }
            }
            finally
            {
                stream.Close();
            }
            return result;
        }
        /// <summary>
        /// Get请求
        /// </summary>
        /// <param name="url">请求url</param>
        /// <param name="dic">自定义参数</param>
        /// <returns></returns>
        public static string Get(string url, Dictionary<string, string> dic=null,string ContentType="")
        {
            string result = "";
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            if (!dic.IsNullOrEmpty())
            {
                builder.Append("?");
                int i = 0;
                foreach (var item in dic)
                {
                    if (i > 0)
                        builder.Append("&");
                    builder.AppendFormat("{0}={1}", item.Key, item.Value);
                    i++;
                }
            }
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(builder.ToString());
            //添加参数
            if (!ContentType.IsNullOrEmpty())
            {
                req.ContentType = ContentType;
                byte[] bytes = Encoding.UTF8.GetBytes(dic.ToJson());
                req.ContentLength = bytes.Length;
                Stream writer = req.GetRequestStream();
                writer.Write(bytes, 0, bytes.Length);
                writer.Close();
            }


            try
            {
                
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                try
                {
                    //获取内容
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        result = reader.ReadToEnd();
                    }
                }
                finally
                {
                    stream.Close();
                }
            }
            catch (WebException web)
            {

                throw web;
            }
            

            return result;
        }
    }
}

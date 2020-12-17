using MT_WMS.Helpes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS
{
    /// <summary>
    /// 全局控制
    /// </summary>
    public class GlobalSwitch
    {
        /// <summary>
        /// 所有程序集
        /// </summary>
        public List<Assembly> AllAssemblies = new List<Assembly>();
        /// <summary>
        /// 所有类型
        /// </summary>
        public List<Type> AllTypes = new List<Type>();
        private static readonly object lock1 = new object();
        static GlobalSwitch gs;
        /// <summary>
        /// 新增一个程序集并且将程序集内的所有类型附加到AllTypes中
        /// </summary>
        /// <param name="assembly"></param>
        public void AddAssembly(Assembly assembly)
        {
            AllAssemblies.Add(assembly);
            AllTypes.AddRange(assembly.GetTypes());
            SnowflakeId a = new SnowflakeId(1L, 2L);
            a.NextId();
        }
        GlobalSwitch()
        {
            var path = Assembly.GetExecutingAssembly().Location;
            string rootPath = Path.GetDirectoryName(path);
            AllAssemblies = Directory.GetFiles(rootPath, "*.dll")
                .Where(x => new FileInfo(x).Name.Contains("MT_WMS"))
                .Select(x => Assembly.LoadFrom(x))
                .Where(x => !x.IsDynamic)
                .ToList();
            AllAssemblies.ForEach(x =>
            {
                try
                {
                    AllTypes.AddRange(x.GetTypes());
                }
                catch
                {
                }
            });

        }
        /// <summary>
        /// 初始化程序全局引用
        /// </summary>
        public static GlobalSwitch Instance
        {
            get
            {
                lock (lock1)
                {
                    if (gs == null)
                    {
                        gs = new GlobalSwitch();
                    }
                    return gs;
                }
            }
        }
        #region 缓存相关
        /// <summary>
        /// 自带简易缓存
        /// </summary>
        private Dictionary<string, object> CacheDictionary = new Dictionary<string, object>();

        /// <summary>
        /// 添加缓存
        /// </summary>
        public void Add(string key, object value)
        {
            CacheDictionary.Add(key, value);
        }
        /// <summary>
        /// 获取缓存
        /// </summary>
        public T Get<T>(string key)
        {
            return (T)CacheDictionary[key];
        }
        /// <summary>
        /// 判断缓存是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Exsits(string key)
        {
            return CacheDictionary.ContainsKey(key);
        }
        #endregion
    }
}

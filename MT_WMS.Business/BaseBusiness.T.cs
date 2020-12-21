using MT_WMS.Helpes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_WMS.Business
{

    public abstract class BaseBusiness<T> where T : class, new()
    {
        //服务请求在这里请求

        /// <summary>
        /// 数据请求Http基础链接
        /// </summary>
        private readonly string BaseUrl = "http://localhost:25672/api/";
        /// <summary>
        /// 服务器路由地址
        /// </summary>
        protected string RouteUrl { get; set; }

        public virtual T GetTheData(string Id)
        {
            var dic = new Dictionary<string, string>();
            dic.Add("input", "0101010004");
            //http服务
            return HttpHelper.Get(BaseUrl+ RouteUrl, dic).ToObject<T>();
        }
        public virtual List<T> GetDataList()
        {
            var dic = new Dictionary<string, string>();
            dic.Add("input", "0101010004");
            //http服务
            return HttpHelper.Get(BaseUrl + RouteUrl, dic).ToList<T>();
        }
        
    }
}

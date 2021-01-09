using MT_WMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_WMS.Business
{
    /// <summary>
    /// 基础业务类
    /// 获取数据用GET
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseBusiness<T> where T : class, new()
    {
        //服务请求在这里请求

        /// <summary>
        /// 数据请求Http基础链接
        /// </summary>
        private readonly string BaseUrl = ConfigHelper.GetKeyValue("URL001") ;


        /// <summary>
        /// 服务器路由地址
        /// </summary>
        protected virtual string RouteUrl
        {
            get { throw new Exception("请在子类里重写"); }
        }
        /// <summary>
        /// 调用的Action方法
        /// </summary>
        protected virtual string ActionUrl { get; set; }
        public virtual string GetUrl()
        {
            return $"{BaseUrl}/{RouteUrl}/{ActionUrl}";
        }
        /// <summary>
        /// 获取某个对象，可重写
        /// </summary>
        /// <param name="Id">列Id并非某个</param>
        /// <returns></returns>
        public virtual T GetTheData(string Id)
        {
            ActionUrl = "GetTheData";
            return GetTheData(Id, ActionUrl);
        }
        /// <summary>
        /// 获取某个对象，不可重写
        /// </summary>
        /// <param name="Id">列Id并非某个</param>
        /// <param name="ActionUrl">请求Action</param>
        /// <returns></returns>
        public  T GetTheData(string Id,string ActionUrl)
        {
             this.ActionUrl= ActionUrl;
            var dic = new Dictionary<string, string>();
            dic.Add("Id",Id);
            var res = HttpHelper.HttpData(GetUrl(), dic:dic);
            return res.ToObject<T>();
        }
        /// <summary>
        /// 获取全部数据
        /// </summary>
        /// <returns></returns>
        public virtual List<T> GetDataList()
        {
            ActionUrl = "GetDataList";
            return GetDataList(ActionUrl);
        }
        public virtual List<T> GetDataList(string ActionUrl)
        {
            this.ActionUrl = ActionUrl;
            var dic = new Dictionary<string, string>();
            var res = HttpHelper.HttpData(GetUrl(), dic: dic);// HttpGetService( dic, GetUrl());
            return res.ToList<T>();
        }
        /// <summary>
        /// 保存当前数据，返回影响行数
        /// </summary>
        /// <param name="theData">保存的数据</param>
        /// <returns></returns>
        public virtual int SaveData(T theData)
        {
            ActionUrl = "SaveData";
            return SaveData(theData,ActionUrl);
        }
        public virtual int SaveData(T theData, string ActionUrl)
        {
            this.ActionUrl = ActionUrl;
            var dic = new Dictionary<string, string>();
            var res = HttpHelper.HttpData(GetUrl(),HttpMethod:"POST", dic: dic,Parameter:theData.ToJson());// HttpGetService( dic, GetUrl());
            return int.Parse(res);
        }
        public int DeleteData(List<string> ids)
        {
            ActionUrl = "DeleteData";
            return DeleteData(ids, ActionUrl);
        }
        public int DeleteData(List<string> ids,string ActionUrl)
        {
            this.ActionUrl = ActionUrl;
            var dic = new Dictionary<string, string>();
            var res = HttpHelper.HttpData(GetUrl(), HttpMethod: "POST", dic: dic, Parameter: ids.ToJson());// HttpGetService( dic, GetUrl());
            return int.Parse(res);
        }
    }
}

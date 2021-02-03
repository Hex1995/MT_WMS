using MT_WMS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
        public BaseBusiness()
        {
            BaseUrl = ConfigHelper.GetKeyValue("RELEASEURL");
#if DEBUG
            BaseUrl = ConfigHelper.GetKeyValue("DEBUGURL");
#endif
        }
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
            ActionUrl = System.Reflection.MethodBase.GetCurrentMethod().Name;;
            return GetTheData(Id, ActionUrl);
        }
        public virtual DataSet ExecuteSql(SqlDTO sql)
        {
            return null;
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
            ActionUrl = System.Reflection.MethodBase.GetCurrentMethod().Name;
            return GetDataList(ActionUrl);
        }
        public virtual List<T> GetDataList(string ActionUrl)
        {
            this.ActionUrl = ActionUrl;
            var dic = new Dictionary<string, string>();
            var res = HttpHelper.HttpData(GetUrl(), dic: dic);
            return res.ToList<T>();
        }
        public virtual DataTable GetTable(List<string> filter)
        {
            ActionUrl = System.Reflection.MethodBase.GetCurrentMethod().Name;
            return HttpHelper.HttpData(GetUrl(), "POST", new Dictionary<string, string>(), filter.ToJson()).ToDataTable();
        }
        /// <summary>
        /// 保存当前数据，返回影响行数
        /// </summary>
        /// <param name="theData">保存的数据</param>
        /// <returns></returns>
        public virtual int SaveData(T theData)
        {
            ActionUrl = System.Reflection.MethodBase.GetCurrentMethod().Name;
            return SaveData(theData,ActionUrl);
        }
        public virtual int SaveData(T theData, string ActionUrl)
        {
            this.ActionUrl = ActionUrl;
            var dic = new Dictionary<string, string>();
            var res = HttpHelper.HttpData(GetUrl(),HttpMethod:"POST", dic: dic,Parameter:theData.ToJson());
            return int.Parse(res);
        }
        public int DeleteData(List<string> ids)
        {
            ActionUrl = System.Reflection.MethodBase.GetCurrentMethod().Name;;
            return DeleteData(ids, ActionUrl);
        }
        public virtual int DeleteData(List<string> ids,string ActionUrl)
        {
            this.ActionUrl = ActionUrl;
            var dic = new Dictionary<string, string>();
            var res = HttpHelper.HttpData(GetUrl(), HttpMethod: "POST", dic: dic, Parameter: ids.ToJson());
            return int.Parse(res);
        }
        public virtual int UpdateData(T theData)
        {
            ActionUrl = System.Reflection.MethodBase.GetCurrentMethod().Name;
            return UpdateData(theData,ActionUrl);
        }
        
        public virtual int UpdateData(T theData,string ActionUrl)
        {
            this.ActionUrl = ActionUrl;
            var dic = new Dictionary<string, string>();
            var res = HttpHelper.HttpData(GetUrl(), HttpMethod: "POST", dic: dic, Parameter: theData.ToJson());
            return int.Parse(res);
        }
    }
}

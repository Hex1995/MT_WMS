using MT_WMS.Api.DataSource;
using MT_WMS.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MT_WMS.Api.Controllers
{
    public class SysObjectValueController : ApiController
    {
        private MTDbContext db = new MTDbContext();
        [HttpPost]
        public int SaveData(SYSOBJECTVALUE theData)
        {
            var t=  db.SYSOBJECTVALUES.Count(x => x.OBJECTID == theData.OBJECTID && x.OBJECTDESCR==theData.OBJECTDESCR) > 0 ?  null: db.SYSOBJECTVALUES.Add(theData);
            return db.SaveChanges();
        }
        [HttpGet]
        public List<SYSOBJECTVALUE> GetDataListByObjectid(string id)
        {
            var data = db.SYSOBJECTVALUES.Where(x => x.OBJECTID == id).ToList();
            return data;
        }
        /// <summary>
        /// 删除对象以及相关对象值
        /// 返回删除对象的行数
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPost]
        public int DeleteData(List<int> ids)
        {
            var deleteobjectvalue = db.SYSOBJECTVALUES.Where(x => ids.Contains(x.PKID)).ToList();
            db.SYSOBJECTVALUES.RemoveRange(deleteobjectvalue);
            var n = db.SaveChanges();
            return n;
        }
    }
}

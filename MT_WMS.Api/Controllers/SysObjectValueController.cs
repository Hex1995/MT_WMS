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
    public class SysObjectValueController : BaseApi<SYSOBJECTVALUE>
    {

        public override int SaveData(SYSOBJECTVALUE theData)
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
        public override int DeleteData(List<string> ids)
        {
            var deleteobjectvalue = db.SYSOBJECTVALUES.Where(x => ids.Contains(x.OBJECTVALUE)).ToList();
            db.SYSOBJECTVALUES.RemoveRange(deleteobjectvalue);
            var n = db.SaveChanges();
            return n;
        }

        public override SYSOBJECTVALUE GetTheData(string id)
        {
            throw new NotImplementedException("暂不支持");
        }


    }
}

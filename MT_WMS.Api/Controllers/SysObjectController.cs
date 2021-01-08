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
    public class SysObjectController : ApiController
    {
        private MTDbContext db = new MTDbContext();
        [HttpGet]
        public virtual List<UserObjects> GetDataList()
        {
            List<UserObjects> objList = null;
            objList = (
                from a in db.SYSOBJECTS
                join b in db.SYSOBJECTVALUES on a.OBJECTID equals b.OBJECTID
                select new UserObjects { ObjectID = a.OBJECTID, ObjectName =a.OBJECTNAME, ObjectValue =b.OBJECTVALUE, ValueDesc = b.OBJECTDESCR }
                ).ToList();
            return objList;
        }

        [HttpGet]
        public virtual bool UserObjectsExistsByName(string name)
        {
            return db.SYSOBJECTS.Count(e => e.OBJECTNAME == name) > 0;
        }
        [HttpGet]
        public virtual List<SYSOBJECT> GetAllData()
        {
            return db.SYSOBJECTS.ToList();
        }
        /// <summary>
        /// 对象值数量
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public int GetValueCount(string id)
        {
            var data = (
                from a in db.SYSOBJECTS
                join b in db.SYSOBJECTVALUES on a.OBJECTID equals b.OBJECTID
                where a.OBJECTID == id
                select b.PKID
                ).ToList();
            return data.Count;
        }
        [HttpPost]
        public int SaveData(SYSOBJECT theData)
        {
            db.SYSOBJECTS.Add(theData);

            try
            {
                return db.SaveChanges();
            }
            catch
            {
                return 0;
            }

        }

        /// <summary>
        /// 删除对象以及相关对象值
        /// 返回删除对象的行数
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        [HttpPost]
        public int DeleteData(List<string>ids)
        {
            var deleteobject = db.SYSOBJECTS.Where(x => ids.Contains(x.OBJECTID) || ids.Contains(x.OBJECTNAME)).ToList();
            var deleteobjectvalue = db.SYSOBJECTVALUES.Where(x => ids.Contains(x.OBJECTID)).ToList();
            db.SYSOBJECTS.RemoveRange(deleteobject);
            var m = db.SaveChanges();
            db.SYSOBJECTVALUES.RemoveRange(deleteobjectvalue);
            var n = db.SaveChanges();
            return m;
        }
    }
}

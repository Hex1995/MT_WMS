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
    }
}

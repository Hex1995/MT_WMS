using MT_WMS.Api.DataSource;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MT_WMS.Api.Controllers
{
    public abstract class BaseApi<T> : ApiController where T : class, new()
    {
        public BaseApi()
        {
            _dbSet = db.Set<T>();
        }
        public MTDbContext db = new MTDbContext();
        DbSet<T> _dbSet;

        #region 增
        [HttpPost]
        public virtual int SaveData(T theData)
        {
            _dbSet.Add(theData);
            return db.SaveChanges();
        }
        #endregion

        #region 查
        [HttpGet]
        public abstract T GetTheData(string id);
        [HttpPost]
        public abstract DataTable GetTable(List<string> filter);

        [HttpPost]
        public virtual DataSet ExecuteSql(SqlDTO sql)
        {
            return null;
        }



        #endregion

        #region 删
        [HttpPost]
        public abstract int DeleteData(List<string> ids);
        #endregion

        #region 改
        [HttpPost]
        public virtual int UpdateData(T theData)
        {
            var d = db.Entry<T>(theData);
            d.State = EntityState.Modified;
            return SaverChanges();
        }
        #endregion



        #region 统一提交
        public int SaverChanges()
        {
            return db.SaveChanges();
        }
        #endregion

        #region 回收
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion


        #region 网络检测
        /// <summary>
        /// 检测网络
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public bool NetCheck()
        {
            return true;
        }
        #endregion
    }
}
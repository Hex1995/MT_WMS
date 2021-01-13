using MT_WMS.Api.DataSource;
using System;
using System.Collections.Generic;
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
        [HttpGet]
        public  abstract T GetTheData(string id);
        [HttpPost]
        public virtual int SaveData(T theData)
        {
            _dbSet.Add(theData);
            return db.SaveChanges();
        }
        [HttpPost]
        public virtual int UpdateData(T theData)
        {
            var d = db.Entry<T>(theData);
            d.State = EntityState.Modified;
            return SaverChanges();
        }
        [HttpPost]
        public abstract int DeleteData(List<string> ids);
        
        public int SaverChanges()
        {
            return db.SaveChanges();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
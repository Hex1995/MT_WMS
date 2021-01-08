using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MT_WMS.Api.DataSource;
using MT_WMS.Entitys;

namespace MT_WMS.Api.Controllers
{
    public class ProductLabelRecordController : ApiController
    {
        private MTDbContext db = new MTDbContext();

        [HttpPost]
        public int SaveData(ProductLabelRecord theData)
        {
            db.ProductLabelRecord.Add(theData);

            try
            {
                return db.SaveChanges();
            }
            catch
            {
                return 0;
            }

        }
        [HttpPost]
        public DataTable GetTableTop10(List<string> filter)
        {
            var sql = $@"
  SELECT TOP 10
  a.ProductSN,
  b.ProductId,
 a.ProductSpec,
  b.ProductName,
 a.Num,
  a.MixDegree,
  a.GroWeight
  FROM [dbo].[Part_ProductLabelRecord] as a 
  inner join [dbo].[Part_Product] as b on a.ProductId=b.ProductId 
 where 1=1
";
            foreach (var item in filter)
            {
                sql += $" {item} ";
            }
            return SqlDbHelpr.Query(sql, SqlDbHelpr.MT).Tables[0];
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductLabelRecordExists(string id)
        {
            return db.ProductLabelRecord.Count(e => e.Id == id) > 0;
        }
    }
}
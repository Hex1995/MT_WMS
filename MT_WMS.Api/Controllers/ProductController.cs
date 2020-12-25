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
    public class ProductController : ApiController
    {
        private MTDbContext db = new MTDbContext();
        public Product GetTheData(string id)
        {
            var data = db.Product.Where(x => x.ProductId == id).ToList().FirstOrDefault();
            return data;
        }
        [HttpPost]
        public DataTable GetProducts(List<string> filter)
        {
            var sql = $@"
SELECT 
        [ProductId] as '编码'
      ,[ProductName] as '产品名称'
      ,[ProductSpec] as '规格'
      ,[ProductUnit] as '单位'
      ,[ProductType] as '类型'
  FROM [dbo].[Part_Product]
 where 1=1 
";
            foreach (var item in filter)
            {
                sql += $" and {item} ";
            }
            return SqlDbHelpr.Query(sql, SqlDbHelpr.MT).Tables[0];
        }
        public List<Product> GetDataList()
        {
            return db.Product.ToList();
        }
        [HttpGet]
        public DataTable GetTable()
        {
            var sql = $@"
SELECT 
        [ProductId] as '编码'
      ,[ProductName] as '产品名称'
      ,[ProductSpec] as '规格'
      ,[ProductUnit] as '单位'
      ,[ProductType] as '类型'
  FROM [dbo].[Part_Product]
";
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

        private bool ProductExists(string id)
        {
            return db.Product.Count(e => e.ProductId == id) > 0;
        }
    }
}
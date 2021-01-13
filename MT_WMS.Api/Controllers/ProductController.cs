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
    public class ProductController : BaseApi<Product>
    {
        //private MTDbContext db = new MTDbContext();
        public override Product GetTheData(string id)
        {
            var data = db.Product.Where(x => x.ProductId == id).ToList().FirstOrDefault();
            return data;
        }
        [HttpPost]
        public DataTable GetProducts(List<string> filter)
        {
            /*
        [ProductId] as '编码'
      ,[ProductName] as '产品名称'
      ,[ProductSpec] as '规格'
      ,[ProductUnit] as '单位'
      ,[ProductType] as '类型'
             */
            var sql = $@"
SELECT 
	   [ProductId]
      ,[ProductName]
      ,[ProductSpec]
      ,[ProductUnit]
      ,[ProductTypeName]
      ,[ProductType]
  FROM [dbo].[Part_Product]
  where 1=1 and EnableMark=1 
";
            foreach (var item in filter)
            {
                sql += $" {item} ";
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
        private bool ProductExists(string id)
        {
            return db.Product.Count(e => e.ProductId == id) > 0;
        }

        public override int DeleteData(List<string> ids)
        {
            var del = db.Product.Where(x => ids.Contains(x.ProductId));
            foreach (var item in del)
            {
                db.Product.Remove(item);
            }
            return SaverChanges();
        }

        public override DataTable GetTable(List<string> filter)
        {
            var sql = $@"
SELECT 
	   [ProductId]
      ,[ProductName]
      ,[ProductSpec]
      ,[ProductUnit]
      ,[ProductTypeName]
      ,[ProductType]
  FROM [dbo].[Part_Product]
  where 1=1 and EnableMark=1 
";
            foreach (var item in filter)
            {
                sql += $" {item} ";
            }
            return SqlDbHelpr.Query(sql, SqlDbHelpr.MT).Tables[0];
        }
    }
}
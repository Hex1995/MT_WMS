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
        [HttpGet]
        public Product GetTheData(string input)
        {
            var data = db.Product.Where(x => x.ProductId == input).ToList().FirstOrDefault();
            return data;
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
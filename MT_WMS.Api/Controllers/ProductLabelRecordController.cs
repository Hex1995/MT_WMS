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

        // GET: api/ProductLabelRecord
        public IQueryable<ProductLabelRecord> GetProductLabelRecord()
        {
            return db.ProductLabelRecord;
        }

        // GET: api/ProductLabelRecord/5
        [ResponseType(typeof(ProductLabelRecord))]
        public IHttpActionResult GetProductLabelRecord(string id)
        {
            ProductLabelRecord productLabelRecord = db.ProductLabelRecord.Find(id);
            if (productLabelRecord == null)
            {
                return NotFound();
            }

            return Ok(productLabelRecord);
        }

        // PUT: api/ProductLabelRecord/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProductLabelRecord(string id, ProductLabelRecord productLabelRecord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productLabelRecord.Id)
            {
                return BadRequest();
            }

            db.Entry(productLabelRecord).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductLabelRecordExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ProductLabelRecord
        [ResponseType(typeof(ProductLabelRecord))]
        public IHttpActionResult PostProductLabelRecord(ProductLabelRecord productLabelRecord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductLabelRecord.Add(productLabelRecord);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProductLabelRecordExists(productLabelRecord.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = productLabelRecord.Id }, productLabelRecord);
        }

        // DELETE: api/ProductLabelRecord/5
        [ResponseType(typeof(ProductLabelRecord))]
        public IHttpActionResult DeleteProductLabelRecord(string id)
        {
            ProductLabelRecord productLabelRecord = db.ProductLabelRecord.Find(id);
            if (productLabelRecord == null)
            {
                return NotFound();
            }

            db.ProductLabelRecord.Remove(productLabelRecord);
            db.SaveChanges();

            return Ok(productLabelRecord);
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
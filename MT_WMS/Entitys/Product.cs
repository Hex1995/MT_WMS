using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MT_WMS.Entitys
{
    [Table("Part_Product")]
    /// <summary>
    /// Part_Product
    /// </summary>
    public class Product
    {
        [Key]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductSpec { get; set; }
        public string ProductUnit { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductType { get; set; }
        public Nullable<decimal> ProductWeight { get; set; }
        public Nullable<decimal> ProductPrice { get; set; }
        public Nullable<decimal> LastPrice { get; set; }
        public Nullable<int> EnableMark { get; set; }
        public string Barcode { get; set; }
        public Nullable<decimal> LimitMaxNum { get; set; }
        public Nullable<decimal> LimitMinNum { get; set; }
        public string AttributeName { get; set; }
        public string SimpleSpelling { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public string Remark { get; set; }
        public string Remark2 { get; set; }
        public string Remark3 { get; set; }
        public string Remark4 { get; set; }
        public string Remark5 { get; set; }
        public string CategoryId { get; set; }
        public Nullable<int> IsTrace { get; set; }
        public string Id { get; set; }
    }
}

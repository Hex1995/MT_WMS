using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_WMS.Entitys
{
    public class ProductLabelRecord
    {
        public string Id { get; set; }
        public string ProductSN { get; set; }
        public string BatchId { get; set; }
        public string OrignBillId { get; set; }
        public string ProductId { get; set; }
        public string ProductSpec { get; set; }
        public string MixDegree { get; set; }
        public string ProductLength { get; set; }
        public string ProductUnit { get; set; }
        public string SubUnit { get; set; }
        public string PrintIn_StoreId { get; set; }
        public string InStorePlaceId { get; set; }
        public Nullable<decimal> Num { get; set; }
        public Nullable<decimal> SubNum { get; set; }
        public string StorePlaceId { get; set; }
        public Nullable<decimal> StoreNum { get; set; }
        public Nullable<decimal> StoreSubNum { get; set; }
        public Nullable<decimal> GroWeight { get; set; }
        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string StoreId { get; set; }
        public Nullable<int> StatusMark { get; set; }
        public Nullable<int> EnableMark { get; set; }
        public Nullable<int> DeleteMark { get; set; }
        public string Remark1 { get; set; }
        public string Remark2 { get; set; }
        public string Remark3 { get; set; }
        public string Remark4 { get; set; }
        public string Remark5 { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}

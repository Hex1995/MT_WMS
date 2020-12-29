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
        /// <summary>
        /// 产品编号
        /// </summary>
        [Key]
        public string ProductId { get; set; }
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 产品规格
        /// </summary>
        public string ProductSpec { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string ProductUnit { get; set; }
        /// <summary>
        /// 产品类型名称
        /// </summary>
        public string ProductTypeName { get; set; }
        /// <summary>
        /// 产品类型
        /// </summary>
        public string ProductType { get; set; }
        /// <summary>
        /// 重量
        /// </summary>
        public Nullable<decimal> ProductWeight { get; set; }
        /// <summary>
        /// 产品价格
        /// </summary>
        public Nullable<decimal> ProductPrice { get; set; }
        /// <summary>
        /// 最近一次价格
        /// </summary>
        public Nullable<decimal> LastPrice { get; set; }
        /// <summary>
        /// 1启 0不启用
        /// </summary>
        public Nullable<int> EnableMark { get; set; }
        /// <summary>
        /// 商品条码
        /// </summary>
        public string Barcode { get; set; }
        /// <summary>
        /// 库存上限
        /// </summary>
        public Nullable<decimal> LimitMaxNum { get; set; }
        /// <summary>
        /// 库存下限
        /// </summary>
        public Nullable<decimal> LimitMinNum { get; set; }
        /// <summary>
        /// 属性
        /// </summary>
        public string AttributeName { get; set; }
        /// <summary>
        /// 简写
        /// </summary>
        public string SimpleSpelling { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public Nullable<System.DateTime> CreateDate { get; set; }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public Nullable<System.DateTime> ModifyDate { get; set; }
        /// <summary>
        /// 修改人ID
        /// </summary>
        public string ModifyUserId { get; set; }
        /// <summary>
        /// 修改人名称
        /// </summary>
        public string ModifyUserName { get; set; }
        /// <summary>
        /// Remark1-n备注
        /// </summary>
        public string Remark { get; set; }
        public string Remark2 { get; set; }
        public string Remark3 { get; set; }
        public string Remark4 { get; set; }
        public string Remark5 { get; set; }
        /// <summary>
        /// 类型0原料1产品
        /// </summary>
        public string CategoryId { get; set; }
        /// <summary>
        /// 是否追溯SN0否1是
        /// </summary>
        public Nullable<int> IsTrace { get; set; }
        /// <summary>
        /// 数据ID
        /// </summary>
        public string Id { get; set; }
    }
}

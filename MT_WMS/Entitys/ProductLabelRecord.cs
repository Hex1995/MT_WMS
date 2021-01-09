using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MT_WMS.Entitys
{
    [Table("Part_ProductLabelRecord")]
    public class ProductLabelRecord
    {
        /// <summary>
        /// 数据ID
        /// </summary>
        [Key]
        public string Id { get; set; }
        /// <summary>
        /// 产品SN编码
        /// </summary>
        public string ProductSN { get; set; }
        /// <summary>
        /// 班组Id
        /// </summary>
        public string TeamId { get; set; }
        /// <summary>
        /// 质检员Id
        /// </summary>
        public string QualityId { get; set; }
        /// <summary>
        /// 批次ID
        /// </summary>
        public string BatchId { get; set; }
        /// <summary>
        /// 源头单号
        /// </summary>
        public string OrignBillId { get; set; }
        /// <summary>
        /// 产品编码
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string ProductSpec { get; set; }
        /// <summary>
        /// 合金度
        /// </summary>
        public string MixDegree { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        public string ProductLength { get; set; }
        /// <summary>
        /// 主单位
        /// </summary>
        public string ProductUnit { get; set; }
        /// <summary>
        /// 辅单位
        /// </summary>
        public string SubUnit { get; set; }
        /// <summary>
        /// 打印入库仓库
        /// </summary>
        public string PrintIn_StoreId { get; set; }
        /// <summary>
        /// 入库库位
        /// </summary>
        public string InStorePlaceId { get; set; }
        /// <summary>
        /// 标签主数量 (一般是默认重量千克)
        /// </summary>
        public Nullable<decimal> Num { get; set; }
        /// <summary>
        /// 标签辅助数量
        /// </summary>
        public Nullable<decimal> SubNum { get; set; }
        /// <summary>
        /// 入库库位存储位置
        /// </summary>
        public string StorePlaceId { get; set; }
        /// <summary>
        /// 库存主数量 S(一般是默认重量千克)
        /// </summary>
        public Nullable<decimal> StoreNum { get; set; }
        /// <summary>
        /// 库存辅助数量
        /// </summary>
        public Nullable<decimal> StoreSubNum { get; set; }
        /// <summary>
        /// 毛重
        /// </summary>
        public Nullable<decimal> GroWeight { get; set; }
        /// <summary>
        /// 供应商编码
        /// </summary>
        public string SupplierId { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string SupplierName { get; set; }
        /// <summary>
        /// 仓库
        /// </summary>
        public string StoreId { get; set; }
        /// <summary>
        ///  状态 0代表待入库、代表已入库
        /// </summary>
        public Nullable<int> StatusMark { get; set; }
        /// <summary>
        ///   1启用、0关闭
        /// </summary>
        public Nullable<int> EnableMark { get; set; }
        /// <summary>
        ///   1删除如果是修改参数的时候需要删除标记出库之前可以操作
        /// </summary>
        public Nullable<int> DeleteMark { get; set; }
        /// <summary>
        /// Remark 1-n 备注
        /// </summary>
        public string Remark1 { get; set; }
        public string Remark2 { get; set; }
        public string Remark3 { get; set; }
        public string Remark4 { get; set; }
        public string Remark5 { get; set; }
        /// <summary>
        /// 生成时间
        /// </summary>
        public Nullable<System.DateTime> CreateDate { get; set; }
        /// <summary>
        /// 创建人id
        /// </summary>
        public string CreateUserId { get; set; }
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string CreateUserName { get; set; }
        /// <summary>
        /// 修改时间
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
    }
}

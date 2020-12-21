using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MT_WMS.Entitys;

namespace MT_WMS.Api.DataSource
{
    public class MTDbContext : DbContext
    {
        /// <summary>
        /// 键对象
        /// </summary>
        public DbSet<SYSOBJECT> SYSOBJECTS { get; set; }
        /// <summary>
        /// 键的值
        /// </summary>
        public DbSet<SYSOBJECTVALUE> SYSOBJECTVALUES { get; set; }
        /// <summary>
        /// 产品标签记录
        /// </summary>
        public DbSet<ProductLabelRecord> ProductLabelRecord { get; set; }
        /// <summary>
        /// 产品表
        /// </summary>
        public DbSet<Product> Product { get; set; }
    }
}
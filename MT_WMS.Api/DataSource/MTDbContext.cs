using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MT_WMS.Entitys;

namespace MT_WMS.Api.DataSource
{
    public class MTDbContext: DbContext
    {
        public DbSet<SYSOBJECT> SYSOBJECTS { get; set; }
        public DbSet<SYSOBJECTVALUE> SYSOBJECTVALUES { get; set; }
    }
}
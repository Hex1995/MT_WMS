﻿using System;
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
    public class ProductLabelRecordController :BaseApi<ProductLabelRecord>
    {
        public override ProductLabelRecord GetTheData(string id)
        {
            throw new NotImplementedException("暂不支持");
        }
        public override DataTable GetTable(List<string> filter)
        {
            var sql = $@"
  SELECT 
  a.ProductSN,
  b.ProductId,
 a.ProductSpec,
 c.OBJECTDESCR as Team,
 d.OBJECTDESCR as Quality,
  b.ProductName,
 a.Num,
  a.MixDegree,
  a.GroWeight
  FROM [dbo].[Part_ProductLabelRecord] as a 
  inner join [Part_Product] as b on a.ProductId=b.ProductId 
  left join [SYS_OBJECT_VALUE] as c on a.TeamId=c.OBJECTVALUE
  left join [SYS_OBJECT_VALUE] as d on a.QualityId=d.OBJECTVALUE
 where 1=1
";
            foreach (var item in filter)
            {
                sql += $" {item} ";
            }
            return SqlDbHelpr.Query(sql, SqlDbHelpr.MT).Tables[0];
        }
        public override int DeleteData(List<string> ids)
        {
            throw new NotImplementedException("暂不支持");
        }


        [HttpPost]
        public int GetSwiftNumber(List<string> filter)
        {
            var sql = $@"
  SELECT TOP 1
    SwiftNumber
  FROM [dbo].[Part_ProductLabelRecord]
 where 1=1
";
            foreach (var item in filter)
            {
                sql += $" {item} ";
            }
            var tb = SqlDbHelpr.Query(sql, SqlDbHelpr.MT).Tables[0];
            if (tb.Rows.Count > 0)
                return tb.Rows[0]["SwiftNumber"].ToString().ToInt()+1;
            else
                return 1;
        }

        private bool ProductLabelRecordExists(string id)
        {
            return db.ProductLabelRecord.Count(e => e.Id == id) > 0;
        }


    }
}
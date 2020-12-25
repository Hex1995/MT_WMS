using MT_WMS.Entitys;
using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MT_WMS.Business.MT
{
    public class ProductBusiness: BaseBusiness<Product>, IProductBusiness
    {
        public ProductBusiness()
        {
        }
        protected override string RouteUrl => "Product";

        public DataTable GetProducts(List<string> filter)
        {
            ActionUrl = "GetProducts";
            return HttpHelper.HttpData(GetUrl(),Parameter:filter.ToJson(),HttpMethod:"POST").ToDataTable();
        }

        public DataTable GetTable()
        {
            ActionUrl = "GetTable";
            return    HttpHelper.HttpData(GetUrl()).ToDataTable();
        }
    }
}

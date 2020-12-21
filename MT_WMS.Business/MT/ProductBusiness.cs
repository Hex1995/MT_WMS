using MT_WMS.Entitys;
using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_WMS.Business.MS
{
    public class ProductBusiness: BaseBusiness<Product>, IProductBusiness
    {
        public override Product GetTheData(string Id)
        {
            RouteUrl = "Product/GetTheData";
            return base.GetTheData(Id);
        }
    }
}

using MT_WMS.Entitys;
using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.Business.MT
{
    public class ProductLabelRecordBusiness: BaseBusiness<ProductLabelRecord>, IProductLabelRecordBusiness
    {
        protected override string RouteUrl => "ProductLabelRecord";
    }
}

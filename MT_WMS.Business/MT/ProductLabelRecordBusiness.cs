using MT_WMS.Entitys;
using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.Business.MT
{
    public class ProductLabelRecordBusiness: BaseBusiness<ProductLabelRecord>, IProductLabelRecordBusiness
    {
        protected override string RouteUrl => "ProductLabelRecord";

        public int GetSwiftNumber(List<string> filter)
        {
            ActionUrl = "GetSwiftNumber";
            return HttpHelper.HttpData(GetUrl(), "POST", new Dictionary<string, string>(), filter.ToJson()).ToInt();
        }

        public DataTable GetTable(List<string> filter)
        {
            ActionUrl = "GetTable";
            return HttpHelper.HttpData(GetUrl(), "POST", new Dictionary<string, string>(), filter.ToJson()).ToDataTable();
        }
    }
}

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
        /// <summary>
        /// 获取流水号
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public int GetSwiftNumber(List<string> filter)
        {
            ActionUrl = System.Reflection.MethodBase.GetCurrentMethod().Name;//"GetSwiftNumber";
            return HttpHelper.HttpData(GetUrl(), "POST", new Dictionary<string, string>(), filter.ToJson()).ToInt();
        }


    }
}

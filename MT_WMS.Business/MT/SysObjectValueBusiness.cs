using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT_WMS.Entitys;
using MT_WMS.IBusiness;

namespace MT_WMS.Business.MT
{
    public class SysObjectValueBusiness : BaseBusiness<SYSOBJECTVALUE>, ISysObjectValueBusiness
    {
        protected override string RouteUrl => "SysObjectValue";

        public int DeleteData(List<int> ids)
        {
            ActionUrl = "DeleteData";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            return HttpHelper.HttpData(GetUrl(), "POST", dic,ids.ToJson()).ToInt();
        }

        public List<SYSOBJECTVALUE> GetDataListByObjectid(string id)
        {
            ActionUrl = "GetDataListByObjectid";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", id);
            return HttpHelper.HttpData(GetUrl(),"GET",dic).ToList<SYSOBJECTVALUE>();
        }
    }
}

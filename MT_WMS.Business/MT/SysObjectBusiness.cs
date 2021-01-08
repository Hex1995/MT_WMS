using MT_WMS.Entitys;
using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.Business.MT
{
    public class SysObjectBusiness: BaseBusiness<UserObjects>, ISysObjectBusiness
    {
        public SysObjectBusiness()
        {
        }
        protected override string RouteUrl => "SysObject";

        public int SaveData(SYSOBJECT theData)
        {
            ActionUrl = "SaveData";
            return HttpHelper.HttpData(GetUrl(), HttpMethod: "POST",Parameter:theData.ToJson()).ToInt();
        }


        public bool UserObjectsExistsByName(string name)
        {
            ActionUrl = "UserObjectsExistsByName";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("name", name);
            return HttpHelper.HttpData(GetUrl(),HttpMethod:"GET",dic).ToBool();
        }


        #region 数据更新
        public void UpdateObject()
        {
            var data = GetDataList();
            foreach (var item in data)
            {
                Dictionary<string, string> arr = new Dictionary<string, string>();
                arr.Add(item.ObjectValue, item.ValueDesc);
                if (GlobalSwitch.Instance.objValues.ContainsKey(item.ObjectName))
                {
                    arr = GlobalSwitch.Instance.objValues[item.ObjectName];
                    if (!arr.ContainsKey(item.ObjectValue))
                        arr.Add(item.ObjectValue, item.ValueDesc);

                }
                else
                {
                    GlobalSwitch.Instance.objValues.Add(item.ObjectName, arr);
                }
            }
        }

        public List<SYSOBJECT> GetAllData()
        {
            ActionUrl = "GetAllData";
            return HttpHelper.HttpData(GetUrl()).ToList<SYSOBJECT>();
        }

        public int GetValueCount(string id)
        {
            ActionUrl = "GetValueCount";
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("id", id);
            return HttpHelper.HttpData(GetUrl(),"GET",dic).ToInt();
        }
        #endregion
    }
}

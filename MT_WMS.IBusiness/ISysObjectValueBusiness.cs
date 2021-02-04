using MT_WMS.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.IBusiness
{
    public interface ISysObjectValueBusiness:IBaseBusiness
    {
        List<SYSOBJECTVALUE> GetDataListByObjectid(string id);
        int SaveData(SYSOBJECTVALUE theData);
        int DeleteData(List<string> ids);
    }
}

using MT_WMS.Entitys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.IBusiness
{
    public interface ISysObjectBusiness: IBaseBusiness
    {
        int SaveData(SYSOBJECT theData);
        List<UserObjects> GetDataList();
        bool UserObjectsExistsByName(string name);
        void UpdateObject();
        List<SYSOBJECT> GetAllData();
        int GetValueCount(string id);
        int DeleteData(List<string> ids);
    }
}

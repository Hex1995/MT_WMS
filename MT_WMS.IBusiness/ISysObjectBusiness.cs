using MT_WMS.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.IBusiness
{
    public interface ISysObjectBusiness
    {
        int SaveData(SYSOBJECT theData);
        List<UserObjects> GetDataList();
        bool UserObjectsExistsByName(string name);
        void UpdateObject();
        List<SYSOBJECT> GetAllData();
    }
}

using MT_WMS.Entitys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MT_WMS.IBusiness
{
    public interface IProductBusiness: IBaseBusiness
    {
        Product GetTheData(string Id);
        List<Product> GetDataList();
        int SaveData(Product theData);
        int DeleteData(List<string> ids);
        int UpdateData(Product theData);
    }
}

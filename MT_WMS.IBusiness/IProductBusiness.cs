using MT_WMS.Entitys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MT_WMS.IBusiness
{
    public interface IProductBusiness
    {
        Product GetTheData(string Id);
        List<Product> GetDataList();
        DataTable GetProducts(List<string> filter);
        DataTable GetTable();
        int SaveData(Product theData);
    }
}

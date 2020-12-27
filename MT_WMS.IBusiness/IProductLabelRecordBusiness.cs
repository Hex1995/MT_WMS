using MT_WMS.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.IBusiness
{
    public interface IProductLabelRecordBusiness
    {
        int SaveData(ProductLabelRecord theData);
    }
}

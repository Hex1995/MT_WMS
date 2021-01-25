using MT_WMS.Entitys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.IBusiness
{
    public interface IProductLabelRecordBusiness: IBaseBusiness
    {
        int SaveData(ProductLabelRecord theData);
        /// <summary>
        /// 获取流水号
        /// </summary>
        /// <param name="filter">查询条件</param>
        /// <returns></returns>
        int GetSwiftNumber(List<string> filter);
    }
}

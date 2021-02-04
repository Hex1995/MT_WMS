#region
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  Hex 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：LAPTOP-1UF0J9CM
 * 命名空间：MT_WMS.IBusiness
 * 唯一标识：9f8ad502-3700-45ce-872c-20be136cc414
 * 文件名：IBaseBusiness
 * 当前用户域：LAPTOP-1UF0J9CM
 * 
 * 创建者：52270
 * 微信:hxy15937916521
 * 创建时间：2021/01/25 14:03:35
 * 描述：
 *
 * ----------------------------------------------------------------
 */
#endregion
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.IBusiness
{
    public interface IBaseBusiness
    {
        DataTable GetTable(List<string> filter);
        DataSet ExecuteSql(SqlDTO sql);
        bool  NetCheck();
    }
}

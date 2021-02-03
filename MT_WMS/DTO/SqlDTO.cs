#region
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  Hex 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：LAPTOP-1UF0J9CM
 * 命名空间：MT_WMS.DTO
 * 唯一标识：0a16bd49-58f9-453d-80da-d5be7f1062eb
 * 文件名：SqlDTO
 * 当前用户域：LAPTOP-1UF0J9CM
 * 
 * 创建者：52270
 * 微信:hxy15937916521
 * 创建时间：2021/02/03 14:46:44
 * 描述：
 *
 * ----------------------------------------------------------------
 */
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS
{
    /// <summary>
    /// 客户端向服务器传送Sql语句
    /// </summary>
    public class SqlDTO
    {
        public string sql { get; set; }
    }
}

#region
/*----------------------------------------------------------------
 * 版权所有 (c) 2021  Hex 保留所有权利。
 * CLR版本：4.0.30319.42000
 * 机器名称：LAPTOP-1UF0J9CM
 * 命名空间：MT_WMS.Win.ControlLibrary
 * 唯一标识：e55891c1-b248-4d93-a195-2b41748b76a5
 * 文件名：UIDataBind
 * 当前用户域：LAPTOP-1UF0J9CM
 * 
 * 创建者：52270
 * 微信:hxy15937916521
 * 创建时间：2021/01/25 15:10:11
 * 描述：
 *
 * ----------------------------------------------------------------
 */
#endregion
using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS.Win.ControlLibrary
{
    /// <summary>
    /// 控件数据绑定
    /// </summary>
    public class DataBind
    {
        
        /// <summary>
        /// 初始化ComboBox的值
        /// 指定
        /// </summary>
        /// <param name="obj">权限对象</param>
        /// <param name="ctr"></param>
        /// <param name="defaultSelect">默认选择项的值</param>
        public static void InitialItems(string obj, ComboBox ctr, string defaultSelect = "")
        {
            ctr.Items.Clear();
            if (GlobalSwitch.Instance.objValues != null && GlobalSwitch.Instance.objValues.Count > 0)
            {
                if (GlobalSwitch.Instance.objValues.Keys.Contains(obj))
                {
                    List<ComboxItem> data = new List<ComboxItem>();
                    foreach (KeyValuePair<string, string> dic in GlobalSwitch.Instance.objValues[obj])
                    {
                        if (!string.IsNullOrEmpty(dic.Key))
                        {
                            data.Add(new ComboxItem(dic.Key, dic.Value));

                        }
                    }
                    ctr.Items.AddRange(data.ToArray());
                    if (!defaultSelect.IsNullOrEmpty())
                    {
                        var tmp = data.Where(x => x.Value() == defaultSelect || x.ToString() == defaultSelect).FirstOrDefault();
                        if (!tmp.IsNullOrEmpty())
                        {
                            ctr.SelectedIndex = ctr.Items.IndexOf(tmp);
                        }
                    }
                    else
                    {
                        if (ctr.Items.Count > 0)
                        {
                            ctr.SelectedIndex = 0;
                        }
                    }

                }
            }
        }
        /// <summary>
        /// Dgv数据绑定
        /// </summary>
        /// <param name="filter">查询条件</param>
        /// <param name="bus">业务对象中的GetTable</param>
        /// <param name="dgv"></param>
        public static void InitialIDgv(List<string> filter, IBaseBusiness bus, DataGridView dgv)
        {
            var data = bus.GetTable(filter);
            if (data == null || data.Rows.Count <= 0)
            {
                DataTable old = (DataTable)dgv.DataSource;
                old.Rows.Clear();
                dgv.DataSource = old;
            }
            else
            {
                dgv.DataSource = data;
            }
        }
        public static void InitialIDgv(List<string> filter,Func<List<string>, DataTable>bus, DataGridView dgv)
        {
            var data = bus.Invoke(filter);
            if (data == null || data.Rows.Count <= 0)
            {
                DataTable old = (DataTable)dgv.DataSource;
                old.Rows.Clear();
                dgv.DataSource = old;
            }
            else
            {
                dgv.DataSource = data;
            }
        }

    }
}

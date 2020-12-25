using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS
{
    public class DataBind
    {
        /// <summary>
        /// 初始化ComboBox的值
        /// </summary>
        /// <param name="obj">权限对象</param>
        /// <param name="ctr"></param>
        public static void InitialItems(string obj, ComboBox ctr)
        {
            ctr.Items.Clear();
            //if (GlobalSwitch.Instance.userObjects != null && GlobalSwitch.Instance.userObjects.Count > 0)
            //{
            //    if (GlobalSwitch.Instance.userObjects.Keys.Contains(obj))
            //    {
            //        foreach (KeyValuePair<string, string> dic in GlobalParams.objValues[obj])
            //        {
            //            if (!string.IsNullOrEmpty(dic.Key))
            //            {
            //                ctr.Items.Add(dic.Key);
            //            }
            //        }
            //        if (ctr.Items.Count > 0)
            //        {
            //            ctr.SelectedIndex = 0;
            //        }
            //    }
            //}
        }
    }
}

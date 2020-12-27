using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WMS
{
    public class ComboxItem
    {
        string _value;
        string _txt;
        public ComboxItem(string Value, string Txt)
        {
            _value = Value;
            _txt = Txt;
        }
        /// <summary>
        /// 获取选中的值
        /// </summary>
        /// <returns></returns>
        public string Value()
        {
            return _value;
        }
        public override string ToString()
        {
            return _txt;
        }
    }
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
            if (GlobalSwitch.Instance.objValues != null && GlobalSwitch.Instance.objValues.Count > 0)
            {
                if (GlobalSwitch.Instance.objValues.Keys.Contains(obj))
                {
                    foreach (KeyValuePair<string, string> dic in GlobalSwitch.Instance.objValues[obj])
                    {
                        if (!string.IsNullOrEmpty(dic.Key))
                        {
                            ctr.Items.Add(new ComboxItem(dic.Value, dic.Key));
                        }
                    }
                    if (ctr.Items.Count > 0)
                    {
                        ctr.SelectedIndex = 0;
                    }
                }
            }
        }
    }
}

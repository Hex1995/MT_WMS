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
        /// 指定
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
        /// <summary>
        /// 初始化ComboBox的值
        /// </summary>
        /// <param name="ctr"></param>
        public static void InitialItems(ComboBox ctr)
        {
            ctr.Items.Clear();
            if (GlobalSwitch.Instance.objValues != null && GlobalSwitch.Instance.objValues.Count > 0)
            {
                foreach (var key in GlobalSwitch.Instance.objValues.Keys)
                {
                    if (GlobalSwitch.Instance.objValues.Keys.Contains(key))
                    {

                            if (!string.IsNullOrEmpty(key))
                            {
                                ctr.Items.Add(new ComboxItem("", key));
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
}

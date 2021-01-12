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
        string _objectvalue;
        string _objectdescr;
        public ComboxItem(string ObjectValue, string ObjectDescr)
        {
            _objectvalue = ObjectValue;
            _objectdescr = ObjectDescr;
        }
        /// <summary>
        /// 获取选中的值
        /// </summary>
        /// <returns></returns>
        public string Value()
        {
            return _objectvalue;
        }
        public override string ToString()
        {
            return _objectdescr;
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
        /// <param name="defaultSelect">默认选择项的值</param>
        public static void InitialItems(string obj, ComboBox ctr,string defaultSelect= "")
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
                        var tmp= data.Where(x => x.Value() == defaultSelect || x.ToString() == defaultSelect).FirstOrDefault();
                        if (!tmp.IsNullOrEmpty())
                        {
                            ctr.SelectedIndex= ctr.Items.IndexOf(tmp);
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

    }
}

using System;
using System.Collections.Generic;
using System.Data;
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
}

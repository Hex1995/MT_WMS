using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MT_WMS.Entitys
{
    /// <summary>
    /// 系统字典名称
    /// </summary>
    public class SYSOBJECT
    {
        /// <summary>
        /// 键的唯一
        /// </summary>
        public int PKID { get; set; }
        /// <summary>
        /// 键ID
        /// </summary>
        public string OBJECTID { get; set; }
        /// <summary>
        /// 键名称
        /// </summary>
        public string OBJECTNAME { get; set; }
    }
}

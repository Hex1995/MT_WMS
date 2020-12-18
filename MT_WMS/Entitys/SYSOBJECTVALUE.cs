using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MT_WMS.Entitys
{
    /// <summary>
    /// 系统字典值
    /// </summary>
    public class SYSOBJECTVALUE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        /// <summary>
        /// 键值的唯一值
        /// </summary>
        public int PKID { get; set; }
        /// <summary>
        /// 键ID，与SYSOBJECT相关联
        /// </summary>
        public string OBJECTID { get; set; }
        /// <summary>
        /// 键值
        /// </summary>
        public string OBJECTVALUE { get; set; }
        /// <summary>
        /// 键值的描述
        /// </summary>
        public string OBJECTDESCR { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace MT_WMS.Entitys
{
    [Table("SYS_OBJECT")]
    /// <summary>
    /// 系统字典名称
    /// </summary>
    public class SYSOBJECT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

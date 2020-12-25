using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.Entitys
{
    /// <summary>
    /// CODE与对象的关联表
    /// </summary>
    [Table("SYS_CODE_OBJECT")]
    public class SYSCODEOBJECT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PKID { get; set; }
        public string CODEID { get; set; }
        public string OBJECTID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.ENTITY.Models.Authorize
{
    [Table("SYS_GROUP")]
    public class SYS_GROUP : DataInfoEntity
    {
        [Required]
        [Column("CODEGROUP")]
        [StringLength(50)]
        public string CodeGroup { get; set; }

        [Required]
        [Column("NAMEGROUP")]
        [StringLength(500)]
        public string NameGroup { get; set; }

        [Column("DESCRIPTION")]
        [StringLength(500)]
        public string Description { get; set; }

    }
}

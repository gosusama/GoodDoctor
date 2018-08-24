using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DG.API.ENTITY.Models.Authorize
{
    [Table("SYS_GROUP_USER")]
    public class SYS_GROUP_USER : DataInfoEntity
    {
        [Required]
        [Column("USERNAME")]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [Column("CODEGROUP")]
        [StringLength(50)]
        public string CodeGroup { get; set; }
    }
}

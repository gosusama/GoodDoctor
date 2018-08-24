using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DG.API.ENTITY.Models.Authorize
{
    [Table("AU_NGUOIDUNG_NHOMQUYEN")]
    public class AU_USER_GROUP_PERMISION : DataInfoEntity
    {
        [Required]
        [StringLength(50)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string ID_GRP_PER { get; set; }
    }
}


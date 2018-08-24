using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DG.API.ENTITY.Models.Authorize
{
    [Table("AU_NHOMQUYEN")]
    public class AU_GROUP_PERMISION : DataInfoEntity
    {

        [StringLength(50)]
        [Required]
        public string ID_GRP_PER { get; set; }

        [StringLength(100)]
        public string NAME_GRP_PER { get; set; }

        [StringLength(200)]
        public string DESC { get; set; }

        [Description("1: sudung | 0 : khongsudung")]
        public int STATE { get; set; }
    }
}

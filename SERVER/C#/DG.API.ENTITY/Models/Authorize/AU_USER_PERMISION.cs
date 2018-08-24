using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DG.API.ENTITY.Models.Authorize
{
    [Table("AU_NGUOIDUNG_QUYEN")]
    public class AU_USER_PERMISION : DataInfoEntity
    {

        [StringLength(50)]
        [Required]
        public string USERNAME { get; set; }

        [StringLength(50)]
        [Required]
        public string ID_FUNC { get; set; }

        [Required]
        public bool VIEW { get; set; }

        [Required]
        public bool ADD { get; set; }

        [Required]
        public bool EDIT { get; set; }

        [Required]
        public bool DELETE { get; set; }

        [Required]
        public bool CONFIRM { get; set; }

        public int STATE { get; set; }
    }
}

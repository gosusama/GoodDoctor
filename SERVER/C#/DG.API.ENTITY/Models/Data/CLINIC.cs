using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.ENTITY.Models.Data
{
    [Table("Clinic")]
    public class Clinic : DataInfoEntity
    {
        [Required]
        [Column("ClinicID")]
        [StringLength(50)]
        public string ClinicID { get; set; }

        [Required]
        [Column("ClinicName")]
        public string ClinicName { get; set; }

        // Thong tin ve Phong kham
        [Column("ClinicDesc")]
        public string ClinicDesc { get; set; }

        [Column("PageRelationship")]
        public string PageRelationship { get; set; }

        [Column("Type")]
        public string Type { get; set; }
    }
}

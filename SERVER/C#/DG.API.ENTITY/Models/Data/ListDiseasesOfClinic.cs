using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.ENTITY.Models.Data
{
    [Table("ListDiseasesOfClinic")]
    public class ListDiseasesOfClinic
    {
        [Required]
        [StringLength(50)]
        [Column("ClinicID")]
        public string ClinicID { get; set; }
        
        [StringLength(50)]
        [Column("DiseasesTypeID")]
        public string DiseasesTypeID { get; set; }
    }
}

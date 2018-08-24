using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.ENTITY.Models.Data
{
    [Table("Diseases")]
    public class Diseases : DataInfoEntity
    {
        [Required]
        [StringLength(50)]
        [Column("DiseasesID")]
        public string DiseasesID { get; set; }

        [Required]
        [StringLength(50)]
        [Column("DiseasesName")]
        public string DiseasesName { get; set; }

        // Thong tin ve benh
        [Column("DiseasesDesc")]
        public string DiseasesDesc { get; set; }
    }
}

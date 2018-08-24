using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.ENTITY.Models.Data
{
    [Table("DiseasesType")]
    public class DiseasesType : DataInfoEntity
    {
        [Required]
        [StringLength(50)]
        [Column("DiseasesTypeID")]
        public string DiseasesTypeID { get; set; }

        [Required]
        [StringLength(50)]
        [Column("DiseasesTypeName")]
        public string DiseasesTypeName { get; set; }
        
    }

}

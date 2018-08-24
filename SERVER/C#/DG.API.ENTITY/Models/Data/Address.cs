using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.ENTITY.Models.Data
{
    [Table("Address")]
    public class Address: DataInfoEntity
    {
        [Required]
        [Column("AddressID")]
        [StringLength(50)]
        public string AddressID { get; set; }

        [Required]
        [Column("AddressName")]
        public string ClinicName { get; set; }

        [Column("NumberPhone")]
        [StringLength(11)]
        public string NumberPhone { get; set; }

        [Column("ClinicID")]
        [StringLength(50)]
        public string ClinicID { get; set; }
    }
}

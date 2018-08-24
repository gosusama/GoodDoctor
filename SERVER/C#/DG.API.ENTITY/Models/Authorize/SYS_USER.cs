using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DG.API.ENTITY.Models.Authorize
{
    [Table("SYS_USER")]
    public class SYS_USER : DataInfoEntity
    {
        [Required]
        [Column("USERNAME")]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [Column("PASSWORD")]
        [StringLength(50, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Column("FULLNAME")]
        [StringLength(200)]
        public string FullName { get; set; }

        [Column("PHONENUMBER")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Column("USERID")]
        [Description("Chứng minh thư")]
        [StringLength(20)]
        public string UserId { get; set; }

        [Column("SEX")]
        public int Sex { get; set; }

        [Column("LEVEL")]
        [Description("Cap Tai Khoan")]
        public Nullable<int> Level { get; set; }

        [Column("STATUS")]
        public int Status { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.ENTITY.Models.Authorize
{
    [Table("THAMSOHETHONG")]
    public class ParameterSystem : DataInfoEntity
    {
        // MODIFIELDMER:OK MÃ NÀY CÓ QUYỀN THAY ĐỔI MÃ DANH MỤC VẬT TƯ HÀNG HÓA
        [Column("MATHAMSO")]
        [StringLength(50)]
        public string MaThamSo { get; set; }
        [Column("TENTHAMSO")]
        [StringLength(500)]
        public string TenThamSo { get; set; }
        [Column("GIATRI")]
        [StringLength(500)]
        public string GiaTri { get; set; }
        [Column("KIEUDULIEU")]
        public Nullable<bool> KieuDuLieu { get; set; }
        [Column("ISEDIT")]
        public Nullable<bool> IsEdit { get; set; }
    }
}

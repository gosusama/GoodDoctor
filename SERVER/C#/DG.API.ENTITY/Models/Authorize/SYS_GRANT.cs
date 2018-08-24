using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DG.API.ENTITY.Models.Authorize
{
    [Table("SYS_GRANT")]
    public class SYS_GRANT : DataInfoEntity
    {
        [Column("USERNAME")]
        [StringLength(50)]
        public string Username { get; set; }

        [Column("MENU")]
        [StringLength(500)]
        public string Menu { get; set; }

        [Column("ISVIEW")]
        public Nullable<int> IsView { get; set; }

        [Column("ISADD")]
        public Nullable<int> IsAdd { get; set; }

        [Column("ISEDIT")]
        public Nullable<int> IsEdit { get; set; }

        [Column("ISDELETE")]
        public Nullable<int> IsDelete { get; set; }

        [Column("ISAPPROVAL")]
        public Nullable<int> IsApproval { get; set; }

        [Column("ISPROMOTION")]
        [Description("Quyền chiết khấu")]
        public Nullable<int> IsPromotion { get; set; }

        [Column("ISVIEWCOC")]
        [Description("Quyền xem giá vốn")]
        public Nullable<int> IsViewCoc { get; set; }

        [Column("ISVIEWGIALE")]
        [Description("Quyền xem giá lẻ")]
        public Nullable<int> IsViewGiaLe { get; set; }

        [Column("ISVIEWGIABUON")]
        [Description("Quyền xem giá buôn")]
        public Nullable<int> IsViewGiaBuon { get; set; }

        [Column("ISVIEWLAILE")]
        [Description("Quyền xem lãi lẻ")]
        public Nullable<int> IsViewLaiLe { get; set; }

        [Column("ISVIEWLAIBUON")]
        [Description("Quyền xem lãi buôn")]
        public Nullable<int> IsViewLaiBuon { get; set; }

        [Column("ISADVANCE")]
        [Description("Quyền nâng cao")]
        public Nullable<int> IsAdvance { get; set; }
    }
}

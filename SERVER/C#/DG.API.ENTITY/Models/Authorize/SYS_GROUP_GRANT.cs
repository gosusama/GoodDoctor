using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.ENTITY.Models.Authorize
{
    [Table("SYS_GROUP_GRANT")]
    public class SYS_GROUP_GRANT : DataInfoEntity
    {
        [Column("ISVIEW")]
        public int IsView { get; set; }

        [Column("ISADD")]
        public int IsAdd { get; set; }

        [Column("ISEDIT")]
        public int IsEdit { get; set; }

        [Column("ISDELETE")]
        public int IsDelete { get; set; }

        [Column("ISAPPROVE")]
        public int IsApprove { get; set; }
    }
}

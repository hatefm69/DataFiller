using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtAssignToPrjDetail : DinawinBaseEntity, IMyEntityDinawin
    {
        public BgtAssignToPrjDetail()
        {
            BgtAssignToPrjSubDetail = new HashSet<BgtAssignToPrjSubDetail>();
        }

        public int BgtAssignToPrjDetailSi { get; set; }
        public int? BgtAssignToPrjSi { get; set; }
        public decimal? BgtAssignToPrjDetailAmnt { get; set; }
        public DateTime? BgtAssignToPrjDetailDate { get; set; }
        public string BgtAssignToPrjDetailDesc { get; set; }
        public string BgtAssignToPrjDetailCu { get; set; }
        public int? SiAccM { get; set; }

        public virtual BgtAssignToPrj BgtAssignToPrjSiNavigation { get; set; }
        public virtual ICollection<BgtAssignToPrjSubDetail> BgtAssignToPrjSubDetail { get; set; }
    }
}

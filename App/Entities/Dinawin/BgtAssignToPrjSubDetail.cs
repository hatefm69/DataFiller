using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtAssignToPrjSubDetail : DinawinBaseEntity, IMyEntityDinawin
    {
        public int BgtAssignToPrjSubDetailSi { get; set; }
        public int? BgtAssignToPrjDetailSi { get; set; }
        public decimal? BgtAssignToPrjSubDetailAmnt { get; set; }
        public DateTime? BgtAssignToPrjSubDetailDate { get; set; }
        public string BgtAssignToPrjSubDetailDesc { get; set; }
        public int? RequestId { get; set; }

        public virtual BgtAssignToPrjDetail BgtAssignToPrjDetailSiNavigation { get; set; }
    }
}

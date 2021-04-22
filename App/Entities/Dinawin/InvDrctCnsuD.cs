using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDrctCnsuD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDrctCnsuHSi { get; set; }
        public int InvGdsSi { get; set; }
        public double InvDrctCnsuDQty { get; set; }
        public decimal? InvDrctCnsuDUntPrc { get; set; }
        public decimal? InvDrctCnsuDTotal { get; set; }
        public int? PurRqstHSi { get; set; }
        public int? InvUntSi { get; set; }

        public virtual InvDrctCnsuH InvDrctCnsuHSiNavigation { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
    }
}

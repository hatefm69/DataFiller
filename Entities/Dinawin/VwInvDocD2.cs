using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvDocD2 : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDocDSi { get; set; }
        public int InvDocHSi { get; set; }
        public int InvGdsSi { get; set; }
        public int InvUntSi { get; set; }
        public double? InvDocDQty { get; set; }
        public decimal InvDocDPrice { get; set; }
        public decimal InvDocDTotal { get; set; }
        public int? CtbCostSi { get; set; }
        public int? CtbProjectSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
    }
}

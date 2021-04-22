using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvCntH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvCntHSi { get; set; }
        public string InvCntHDs { get; set; }
        public string InvCntHTp { get; set; }
        public int InvInvtSi { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
    }
}

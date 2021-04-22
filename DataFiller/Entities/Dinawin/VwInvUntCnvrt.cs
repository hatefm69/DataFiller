using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvUntCnvrt : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvUntSiFr { get; set; }
        public int InvUntSiTo { get; set; }
        public double? InvUntCnvrtCoefficient { get; set; }
    }
}

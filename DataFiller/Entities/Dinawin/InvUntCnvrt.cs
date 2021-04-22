using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvUntCnvrt : DinawinBaseEntity, IMyEntityDinawin     
    {
        public int InvUntSiFr { get; set; }
        public int InvUntSiTo { get; set; }
        public double? InvUntCnvrtCoefficient { get; set; }

        public virtual InvUnt InvUntSiFrNavigation { get; set; }
    }
}

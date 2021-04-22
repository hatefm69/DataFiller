using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvUsrToInv : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvUsrSi { get; set; }
        public int InvInvtSi { get; set; }
    }
}

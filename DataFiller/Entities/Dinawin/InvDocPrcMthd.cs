using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocPrcMthd : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvInvtSi { get; set; }
        public int InvDocTypSi { get; set; }
        public short? InvDocPrcMthdAsf { get; set; }
    }
}

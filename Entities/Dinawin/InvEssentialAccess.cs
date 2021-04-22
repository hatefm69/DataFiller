using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvEssentialAccess : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvEssentialAccessSi { get; set; }
        public string UsesRec { get; set; }
        public bool? InvEssentialAccessAct1 { get; set; }
        public bool? InvEssentialAccessAct2 { get; set; }
    }
}

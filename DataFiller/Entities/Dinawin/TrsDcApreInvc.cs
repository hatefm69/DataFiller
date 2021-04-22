using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDcApreInvc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDcApreInvcSi { get; set; }
        public int TrsDcASi { get; set; }
        public int SalPreInvcHSi { get; set; }
    }
}

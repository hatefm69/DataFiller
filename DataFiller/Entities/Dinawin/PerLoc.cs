using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerLoc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPrsnlDlocSi { get; set; }
        public string PerPrsnlDlocTp { get; set; }
    }
}

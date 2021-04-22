using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsDcS : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? TrsDcSSi { get; set; }
        public int TrsDcCSi { get; set; }
        public int TrsStsSi { get; set; }
        public DateTime? TrsDcSDt { get; set; }
        public string TrsStsTp { get; set; }
        public string TrsDcSTm { get; set; }
    }
}

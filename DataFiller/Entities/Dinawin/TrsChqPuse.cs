using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsChqPuse : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsChqPuseSi { get; set; }
        public int TrsChqPSi { get; set; }
        public int? AccLtSi { get; set; }
        public int TrsDcCIno { get; set; }
        public int TrsDcCSi { get; set; }
        public int? TrsDcTypSi { get; set; }
        public int? TrsCtypSi { get; set; }
    }
}

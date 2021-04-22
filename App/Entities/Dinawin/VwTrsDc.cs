using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsDc: DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDcSi { get; set; }
        public int? TrsDcCu { get; set; }
        public short TrsDcTypSi { get; set; }
        public DateTime TrsDcDt { get; set; }
        public int? TrsDcGrpSi { get; set; }
        public string TrsDcTp { get; set; }
        public bool TrsDcShare { get; set; }
        public string TrsDcTypTp { get; set; }
        public string TrsDcGrpTp { get; set; }
        public byte? TrsDcMnthSi { get; set; }
        public DateTime? StmpCdt { get; set; }
        public string StmpCus { get; set; }
        public string TrsDcTypTp2 { get; set; }
        public int? TrsDcCu2 { get; set; }
        public DateTime? TrsDcStmpCdt { get; set; }
        public string TrsDcStmpTime { get; set; }
        public string TrsDcStmpTimeEdit { get; set; }
        public DateTime? TrsDcStmpMdt { get; set; }
        public string StmpMus { get; set; }
    }
}

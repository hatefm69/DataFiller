using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerIncDec: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerIncDecSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public string PerIncDecDs { get; set; }
        public string PerIncDecTp { get; set; }
        public decimal PerIncDecPrc { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
    }
}

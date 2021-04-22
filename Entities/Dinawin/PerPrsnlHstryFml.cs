using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPrsnlHstryFml : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPrsnlHstryFmlSi { get; set; }
        public string PerPrsnlHstryFmlTp { get; set; }
        public string PerPrsnlHstryFmlTyp { get; set; }
        public DateTime? PerPrsnlHstryFmlDateBrth { get; set; }
        public string PerPrsnlHstryFmlMadrak { get; set; }
        public int? PerPrsnlSi { get; set; }
    }
}

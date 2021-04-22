using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPrsnlHstryMrg : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPrsnlHstryMrgSi { get; set; }
        public string PerPrsnlHstryMrgTp { get; set; }
        public DateTime? PerPrsnlHstryMrgDateStr { get; set; }
        public string PerPrsnlHstryMrgDesc { get; set; }
        public int? PerPrsnlSi { get; set; }
    }
}

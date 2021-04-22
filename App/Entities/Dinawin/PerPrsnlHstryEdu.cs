using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPrsnlHstryEdu : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPrsnlHstryEduSi { get; set; }
        public string PerPrsnlHstryEduBrnch { get; set; }
        public string PerPrsnlHstryEduMadrak { get; set; }
        public string PerPrsnlHstryEduEduPlc { get; set; }
        public string PerPrsnlHstryEduAvg { get; set; }
        public DateTime? PerPrsnlHstryEduDateStr { get; set; }
        public DateTime? PerPrsnlHstryEduDateEnd { get; set; }
        public int? PerPrsnlSi { get; set; }
    }
}

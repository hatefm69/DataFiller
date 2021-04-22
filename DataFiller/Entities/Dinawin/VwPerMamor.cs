using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerMamor: DinawinBaseEntity, IMyEntityDinawin
    {
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public string PerMamorMfds { get; set; }
        public string PerMamorMlds { get; set; }
        public string PerMamorDs { get; set; }
        public string PerMamorCity { get; set; }
        public string PerMamorDesc { get; set; }
        public string PerHamlTp { get; set; }
        public int? PerMamorOnewayTicket { get; set; }
        public double? PerMamorKmGo { get; set; }
        public double? PerMamorKmReturn { get; set; }
        public double? PerMamorKmSum { get; set; }
        public DateTime? PerMamorTimeGo { get; set; }
        public DateTime? PerMamorTimeReturn { get; set; }
        public string PerMamorMfweek { get; set; }
        public string PerMamorMlweek { get; set; }
        public int PerMamorSi { get; set; }
        public int? PerHamlSi { get; set; }
        public int? PerPrsnlSi { get; set; }
    }
}

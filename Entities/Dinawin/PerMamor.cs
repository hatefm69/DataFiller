using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerMamor : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerMamorSi { get; set; }
        public string PerMamorDs { get; set; }
        public int? PerPrsnlSi { get; set; }
        public string PerMamorMfds { get; set; }
        public string PerMamorMlds { get; set; }
        public string PerMamorCity { get; set; }
        public string PerMamorDesc { get; set; }
        public int? PerHamlSi { get; set; }
        public int? PerMamorOnewayTicket { get; set; }
        public double? PerMamorKmGo { get; set; }
        public double? PerMamorKmReturn { get; set; }
        public double? PerMamorKmSum { get; set; }
        public DateTime? PerMamorTimeGo { get; set; }
        public DateTime? PerMamorTimeReturn { get; set; }
        public string PerMamorMfweek { get; set; }
        public string PerMamorMlweek { get; set; }
        public int? PerMamorTashilat { get; set; }
        public string PerMamorTashilFrDs { get; set; }
        public string PerMamorTashilToDs { get; set; }
        public short? PerMamorDay { get; set; }
        public short? PerMamorTime { get; set; }
        public int? PerMamorPlaceSi { get; set; }
        public int? PerMamorNightCount { get; set; }
        public int? PerMamorBrkFcount { get; set; }
        public int? PerMamorNaharCount { get; set; }
        public int? PerMamorDnCount { get; set; }
        public int? PerAirLineSi { get; set; }
        public double? PerMamorPrice { get; set; }
    }
}

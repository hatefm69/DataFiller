using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPrsnlHstryLng : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPrsnlHstryLngSi { get; set; }
        public bool? PerPrsnlHstryLngWrt { get; set; }
        public bool? PerPrsnlHstryLngSpk { get; set; }
        public bool? PerPrsnlHstryLngRead { get; set; }
        public bool? PerPrsnlHstryLngLsn { get; set; }
        public string PerPrsnlHstryLngTp { get; set; }
        public int? PerPrsnlSi { get; set; }
    }
}

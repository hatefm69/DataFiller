using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcStation: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PrdcStationSi { get; set; }
        public int? PrdcStationCu { get; set; }
        public string PrdcStationTp { get; set; }
        public int? CtbCostSi { get; set; }
        public bool? PrdcStationTypeSi { get; set; }
        public string PrdcStationTypeTp { get; set; }
        public int? PrdcStationCapasity { get; set; }
        public string PrdcStationTimeType { get; set; }
        public string PrdcStationTimeTypeName { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
    }
}

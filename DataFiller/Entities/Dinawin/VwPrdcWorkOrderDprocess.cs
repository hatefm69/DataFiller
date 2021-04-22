using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcWorkOrderDprocess: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? PrdcStationCu { get; set; }
        public string PrdcStationTp { get; set; }
        public string PrdcStationTimeType { get; set; }
        public string PrdcStationTimeTypeName { get; set; }
        public int? PrdcStationCapasity { get; set; }
        public string PrdcStationTypeTp { get; set; }
        public bool? PrdcStationTypeSi { get; set; }
        public int? PrdcLineSi { get; set; }
        public double? PrdcWorkOrderDprocessContractorTime { get; set; }
        public double? PrdcWorkOrderDprocessHumanTime { get; set; }
        public double? PrdcWorkOrderDprocessMachineTime { get; set; }
        public int? PrdcStationSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
        public int PrdcWorkOrderDprocessSi { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
    }
}

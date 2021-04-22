using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcWorkOrderProcessCalc: DinawinBaseEntity, IMyEntityDinawin
    {
        public double? PrdcWorkOrderDinfoQuantity { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public int? PrdcStationCu { get; set; }
        public string PrdcStationTp { get; set; }
        public bool? PrdcStationTypeSi { get; set; }
        public string PrdcStationTypeTp { get; set; }
        public int? PrdcStationCapasity { get; set; }
        public string PrdcStationTimeType { get; set; }
        public string PrdcStationTimeTypeName { get; set; }
        public int? PrdcWorkOrderDprocessSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PrdcStationSi { get; set; }
        public double? PrdcWorkOrderDprocessMachineTime { get; set; }
        public double? PrdcWorkOrderDprocessHumanTime { get; set; }
        public double? PrdcWorkOrderDprocessContractorTime { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
        public double? PrdcWorkOrderDprocessMt { get; set; }
        public double? PrdcWorkOrderDprocessHt { get; set; }
        public int? PrdcLineTitleSi { get; set; }
        public double? StationTimeForUnitM { get; set; }
        public double? StationTimeForUnitH { get; set; }
    }
}

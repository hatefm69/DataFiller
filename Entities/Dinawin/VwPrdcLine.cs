using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcLine: DinawinBaseEntity, IMyEntityDinawin
    {
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public int? PrdcLineSi { get; set; }
        public int? PrdcLineTitleSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PrdcStationSi { get; set; }
        public int? PrdcLineMachineTime { get; set; }
        public int? PrdcLineHumanTime { get; set; }
        public double? PrdcLineContractorTime { get; set; }
        public double? PrdcLineScrapValue { get; set; }
        public int? PrdcStationCu { get; set; }
        public string PrdcStationTp { get; set; }
        public string PrdcStationTypeTp { get; set; }
        public int? PrdcStationCapasity { get; set; }
        public string PrdcStationTimeType { get; set; }
        public string PrdcStationTimeTypeName { get; set; }
        public int? PrdcLineTitleCu { get; set; }
        public string PrdcLineTitleTp { get; set; }
        public int? PrdcBomSi { get; set; }
        public double? PrdcBomQuantity { get; set; }
        public bool? PrdcLineChangeInWorkOrder { get; set; }
        public int? PrdcLineMt { get; set; }
        public int? PrdcLineHt { get; set; }
        public int? TimeForLineM { get; set; }
        public int? TimeForLineH { get; set; }
        public double? StationTimeForUnitM { get; set; }
        public double? StationTimeForUnitH { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcTraceDprocess: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PrdcTraceDprocessSi { get; set; }
        public int? PrdcTraceDinfoSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PrdcStationSi { get; set; }
        public int? PrdcTraceDprocessMachineTime { get; set; }
        public int? PrdcTraceDprocessHumanTime { get; set; }
        public int? PrdcTraceDprocessContractor { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public int? PrdcStationCu { get; set; }
        public string PrdcStationTp { get; set; }
        public string PrdcStationTimeTypeName { get; set; }
        public string PrdcStationTypeTp { get; set; }
    }
}

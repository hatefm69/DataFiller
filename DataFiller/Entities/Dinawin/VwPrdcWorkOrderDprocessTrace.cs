using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcWorkOrderDprocessTrace: DinawinBaseEntity, IMyEntityDinawin
    {
        public double? PrdcWorkOrderDprocessMachineTime { get; set; }
        public double? PrdcWorkOrderDprocessHumanTime { get; set; }
        public double? PrdcWorkOrderDprocessContractorTime { get; set; }
        public int? PrdcTraceDprocessMachineTime { get; set; }
        public int? PrdcTraceDprocessHumanTime { get; set; }
        public int? PrdcTraceDprocessContractor { get; set; }
        public int PrdcWorkOrderDprocessSi { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PrdcStationSi { get; set; }
        public int? PrdcTraceDprocessSi { get; set; }
        public int? PrdcTraceDinfoSi { get; set; }
        public double? MachineTimeForTrace { get; set; }
        public double? HumanTimeForTrace { get; set; }
        public double? ContractorTimeForTrace { get; set; }
        public bool? PrdcStationTypeSi { get; set; }
    }
}

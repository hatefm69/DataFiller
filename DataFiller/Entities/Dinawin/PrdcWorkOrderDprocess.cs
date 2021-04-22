using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PrdcWorkOrderDprocess : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PrdcWorkOrderDprocessSi { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PrdcStationSi { get; set; }
        public double? PrdcWorkOrderDprocessMachineTime { get; set; }
        public double? PrdcWorkOrderDprocessHumanTime { get; set; }
        public double? PrdcWorkOrderDprocessContractorTime { get; set; }
        public int? PrdcLineSi { get; set; }

        public virtual CtbCost CtbCostSiNavigation { get; set; }
        public virtual PrdcStation PrdcStationSiNavigation { get; set; }
        public virtual PrdcWorkOrderDinfo PrdcWorkOrderDinfoSiNavigation { get; set; }
    }
}

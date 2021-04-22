using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PrdcTraceDprocess : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PrdcTraceDprocessSi { get; set; }
        public int? PrdcTraceDinfoSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PrdcStationSi { get; set; }
        public int? PrdcTraceDprocessMachineTime { get; set; }
        public int? PrdcTraceDprocessHumanTime { get; set; }
        public int? PrdcTraceDprocessContractor { get; set; }
        public int? PrdcWorkOrderDprocessSi { get; set; }

        public virtual CtbCost CtbCostSiNavigation { get; set; }
        public virtual PrdcStation PrdcStationSiNavigation { get; set; }
        public virtual PrdcTraceDinfo PrdcTraceDinfoSiNavigation { get; set; }
    }
}

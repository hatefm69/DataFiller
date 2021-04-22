using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PrdcLine : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PrdcLineSi { get; set; }
        public int? PrdcLineTitleSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PrdcStationSi { get; set; }
        public int? PrdcLineMachineTime { get; set; }
        public int? PrdcLineHumanTime { get; set; }
        public double? PrdcLineContractorTime { get; set; }
        public double? PrdcLineScrapValue { get; set; }
        public bool? PrdcLineChangeInWorkOrder { get; set; }

        public virtual CtbCost CtbCostSiNavigation { get; set; }
        public virtual PrdcLineTitle PrdcLineTitleSiNavigation { get; set; }
        public virtual PrdcStation PrdcStationSiNavigation { get; set; }
    }
}

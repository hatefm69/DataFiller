using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PrdcStation : DinawinBaseEntity, IMyEntityDinawin
    {
        public PrdcStation()
        {
            PrdcLine = new HashSet<PrdcLine>();
            PrdcTraceDprocess = new HashSet<PrdcTraceDprocess>();
            PrdcWorkOrderDprocess = new HashSet<PrdcWorkOrderDprocess>();
        }

        public int PrdcStationSi { get; set; }
        public int? PrdcStationCu { get; set; }
        public string PrdcStationTp { get; set; }
        public int? CtbCostSi { get; set; }
        public bool? PrdcStationTypeSi { get; set; }
        public int? PrdcStationCapasity { get; set; }
        public string PrdcStationTimeType { get; set; }

        public virtual CtbCost CtbCostSiNavigation { get; set; }
        public virtual ICollection<PrdcLine> PrdcLine { get; set; }
        public virtual ICollection<PrdcTraceDprocess> PrdcTraceDprocess { get; set; }
        public virtual ICollection<PrdcWorkOrderDprocess> PrdcWorkOrderDprocess { get; set; }
    }
}

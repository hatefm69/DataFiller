using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PrdcWorkOrderH : DinawinBaseEntity, IMyEntityDinawin
    {
        public PrdcWorkOrderH()
        {
            PrdcWorkOrderDinfo = new HashSet<PrdcWorkOrderDinfo>();
        }

        public int PrdcWorkOrderHSi { get; set; }
        public string PrdcWorkOrderHCu { get; set; }
        public string PrdcWorkOrderHDate { get; set; }
        public int? PrdcWorkOrderTypeSi { get; set; }
        public short? PrdcWorkOrderHPriority { get; set; }
        public bool? PrdcWorkOrderHStatus { get; set; }
        public string PrdcWorkOrderHFromDate { get; set; }
        public string PrdcWorkOrderHToDate { get; set; }
        public string PrdcWorkOrderHDescription { get; set; }
        public bool? PrdcWorkOrderHLock { get; set; }
        public bool? PrdcWorkOrderHIsTrace1 { get; set; }
        public bool? PrdcWorkOrderHIsTrace2 { get; set; }
        public string PrdcWorkOrderHCreatorUser { get; set; }
        public string PrdcWorkOrderHConfirmationUser { get; set; }

        public virtual ICollection<PrdcWorkOrderDinfo> PrdcWorkOrderDinfo { get; set; }
    }
}

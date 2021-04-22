using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcWorkOrderDinfoTrace: DinawinBaseEntity, IMyEntityDinawin
    {
        public double? PrdcWorkOrderDinfoQuantity { get; set; }
        public double? PrdcTraceDinfoQuantity { get; set; }
        public int? PrdcTraceDinfoSi { get; set; }
        public int PrdcWorkOrderDinfoSi { get; set; }
        public int? PrdcTraceHSi { get; set; }
        public int? PrdcWorkOrderHSi { get; set; }
        public double? QuantityForTrace { get; set; }
        public int? InvGdsSi { get; set; }
        public int? PrdcBomSi { get; set; }
        public int? PrdcLineTitleSi { get; set; }
        public string PrdcWorkOrderHCu { get; set; }
        public string PrdcWorkOrderHDate { get; set; }
        public string PrdcWorkOrderHStatusName { get; set; }
        public string PrdcWorkOrderHPriorityName { get; set; }
        public bool? PrdcWorkOrderHLock { get; set; }
        public bool? PrdcWorkOrderHStatus { get; set; }
    }
}

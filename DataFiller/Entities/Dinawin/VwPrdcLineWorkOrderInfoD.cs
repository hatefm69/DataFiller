using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcLineWorkOrderInfoD: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PrdcWorkOrderDinfoSi { get; set; }
        public bool? PrdcLineChangeInWorkOrder { get; set; }
    }
}

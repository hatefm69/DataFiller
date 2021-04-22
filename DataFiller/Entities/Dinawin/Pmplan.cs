using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Pmplan : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? PmPlanId { get; set; }
        public int? PmOperationDesRefId { get; set; }
        public int? PmPlanTime { get; set; }
        public int? PmPlanWork { get; set; }
    }
}

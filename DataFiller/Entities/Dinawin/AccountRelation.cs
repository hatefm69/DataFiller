using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccountRelation : DinawinBaseEntity, IMyEntityDinawin
    {
        public string GeneralCode { get; set; }
        public string SubsidiaryCode { get; set; }
        public string DetailCode { get; set; }
        public string CostCenterCode { get; set; }
        public string ProjectCode { get; set; }
        public int? Nature { get; set; }
    }
}

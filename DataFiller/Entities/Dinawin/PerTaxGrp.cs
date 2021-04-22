using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerTaxGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerTaxGrpSi { get; set; }
        public string PerTaxGrpCu { get; set; }
        public string PerTaxGrpTp { get; set; }
    }
}

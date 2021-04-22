using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalRetinvcD2 : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvGdsSi { get; set; }
        public double? SalRetInvcDQty { get; set; }
        public int? SalRetInvcHSi { get; set; }
        public double? SalRetInvcDQty2 { get; set; }
        public int? SalRetInvcHCu { get; set; }
    }
}

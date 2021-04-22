using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalinvcD2 : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsSi { get; set; }
        public decimal SalInvcDQty { get; set; }
        public double? SalInvcDQty2 { get; set; }
        public int SalInvcHSi { get; set; }
    }
}

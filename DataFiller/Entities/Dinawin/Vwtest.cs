using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Vwtest : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SalInvcHCu { get; set; }
        public decimal? SalInvcDQty { get; set; }
        public decimal? SalInvcDUntPrc { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalTreasury : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SalInvcHCu { get; set; }
        public string SalInvcHDs { get; set; }
        public string SalCustTp { get; set; }
        public string SalRespTp { get; set; }
        public decimal? SalInvcHPrcTotal { get; set; }
        public double? SalInvcHPrcInc { get; set; }
        public decimal? TrsDcACreditC { get; set; }
        public decimal? TrsDcADebitC { get; set; }
        public int? SalRespSi { get; set; }
    }
}

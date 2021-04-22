using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalTresuryCust : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SalCustSi { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public decimal? TrsDcACreditC { get; set; }
        public decimal? SalInvcHPrcInc { get; set; }
        public decimal? SalInvcHPrcTotal { get; set; }
        public decimal? TrsDcADebitC { get; set; }
    }
}

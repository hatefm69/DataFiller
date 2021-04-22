using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvSumQtySndBorrow : DinawinBaseEntity, IMyEntityDinawin
    {
        public double? SumInvQty { get; set; }
        public int? InvDocTypSi { get; set; }
        public decimal? InvDocDPrice { get; set; }
        public int InvGdsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? PurVndrSi { get; set; }
        public int? SalCustSi { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalCntrctDetailInvc: DinawinBaseEntity, IMyEntityDinawin
    {
        public decimal? SalInvcDQty { get; set; }
        public decimal? SalInvcDUntPrc { get; set; }
        public decimal? SalInvcDTotal { get; set; }
        public int? SalContractHCu { get; set; }
        public int? SalCntrctTypeCu { get; set; }
        public string SalCntrctTypeTp { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public double? SalContractQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? LineTotal { get; set; }
        public string SalCustTp { get; set; }
        public int? InvGdsSi { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalCntrctD: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SalContractHCu { get; set; }
        public int? SalCntrctTypeCu { get; set; }
        public string SalCntrctTypeTp { get; set; }
        public string SalCntrctHDs { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string SalContractTp { get; set; }
        public int? InvGdsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public double? SalContractQuantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? LineTotal { get; set; }
        public string SalCustTp { get; set; }
        public int? SalCustGrpSi { get; set; }
        public int SalContractHSi { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerLoanGivBak: DinawinBaseEntity, IMyEntityDinawin
    {
        public string PerLoanTypCu { get; set; }
        public string PerLoanTypTp { get; set; }
        public int? PerLoanTypSi { get; set; }
        public int? PerLoanCu { get; set; }
        public string PerLoanTp { get; set; }
        public string PerLoanDs { get; set; }
        public decimal? PerLoanRem { get; set; }
        public decimal? PerLoanPrice { get; set; }
        public int? PerLoanStgQty { get; set; }
        public decimal? PerLoanStgPrice { get; set; }
        public string PerLoanStgFirstDate { get; set; }
        public bool? PerLoanFinished { get; set; }
        public int? PerPrsnlSi { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public int PerLoanGivBakSi { get; set; }
        public int PerLoanSi { get; set; }
        public string PerLoanGivBakDs { get; set; }
        public decimal PerLoanGivBakPrice { get; set; }
        public string PerLoanGivBakTp { get; set; }
        public int? PerPyrlPeriodSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? PerLocSi { get; set; }
        public decimal? Remain { get; set; }
        public int? Countloan { get; set; }
    }
}

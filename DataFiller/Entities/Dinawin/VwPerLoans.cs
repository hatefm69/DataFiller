using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerLoans: DinawinBaseEntity, IMyEntityDinawin
    {
        public string PerLoanTypCu { get; set; }
        public string PerLoanTypTp { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public int PerLoanSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public int PerLoanTypSi { get; set; }
        public int? PerLoanCu { get; set; }
        public string PerLoanTp { get; set; }
        public string PerLoanDs { get; set; }
        public decimal PerLoanRem { get; set; }
        public decimal PerLoanPrice { get; set; }
        public int PerLoanStgQty { get; set; }
        public decimal PerLoanStgPrice { get; set; }
        public string PerLoanStgFirstDate { get; set; }
        public bool PerLoanFinished { get; set; }
        public string PerLoanZamen { get; set; }
        public int? PerLocSi { get; set; }
    }
}

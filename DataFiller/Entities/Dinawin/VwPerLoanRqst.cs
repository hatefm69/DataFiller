using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerLoanRqst: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? PerLoanRqstCu { get; set; }
        public string PerLoanRqstTp { get; set; }
        public string PerLoanRqstDs { get; set; }
        public decimal? PerLoanRqstRem { get; set; }
        public decimal PerLoanRqstPrice { get; set; }
        public string PerLoanTypCu { get; set; }
        public int PerLoanTypSi { get; set; }
        public string PerLoanTypTp { get; set; }
        public int PerPrsnlSi { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public int? PerLocSi { get; set; }
        public int PerLoanRqstSi { get; set; }
        public bool? PerLoanRqstAccept { get; set; }
        public int? PerLoanSi { get; set; }
        public int? PerLoanCu { get; set; }
        public string PerLoanTp { get; set; }
        public string PerLoanRqstUserInsert { get; set; }
        public string PerLoanRqstUserAccept { get; set; }
        public string PerLoanRqstDateInsert { get; set; }
        public string PerLoanRqstDateAccept { get; set; }
        public string PerLoanRqstDescAccept { get; set; }
        public string PerPrsnlDlocTp { get; set; }
        public int? PerLoanRqstCountpayment { get; set; }
    }
}

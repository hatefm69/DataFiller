using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerLoanRqst : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerLoanRqstSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public int PerLoanTypSi { get; set; }
        public int? PerLoanRqstCu { get; set; }
        public string PerLoanRqstTp { get; set; }
        public string PerLoanRqstDs { get; set; }
        public decimal? PerLoanRqstRem { get; set; }
        public decimal PerLoanRqstPrice { get; set; }
        public bool? PerLoanRqstAccept { get; set; }
        public int? PerLoanSi { get; set; }
        public string PerLoanRqstUserInsert { get; set; }
        public string PerLoanRqstUserAccept { get; set; }
        public string PerLoanRqstDateInsert { get; set; }
        public string PerLoanRqstDateAccept { get; set; }
        public string PerLoanRqstDescAccept { get; set; }
        public int? PerLoanRqstCountpayment { get; set; }
    }
}

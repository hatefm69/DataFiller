using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsDocVoucher : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDocVchrSi { get; set; }
        public int? TrsDccSi { get; set; }
        public int? TrsDcSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public string TrsDocVchrTp { get; set; }
        public decimal TrsDocVchrDebit { get; set; }
        public decimal TrsDocVchrCredit { get; set; }
        public decimal? TrsDocVchrDebitC { get; set; }
        public decimal? TrsDocVchrCreditC { get; set; }
        public int? AccDocHSi { get; set; }
        public double? TrsDcCIno { get; set; }
        public string TrsDcCIbnk { get; set; }
        public string TrsDcCIbrnch { get; set; }
        public string TrsDcCIaccNo { get; set; }
        public int? Expr2 { get; set; }
        public int? TrsDcCu { get; set; }
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public string TrsDcTypTp { get; set; }
        public DateTime? TrsDcDt { get; set; }
        public DateTime? TrsDcCDt { get; set; }
    }
}

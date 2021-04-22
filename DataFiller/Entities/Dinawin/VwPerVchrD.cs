using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerVchrD: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerVchrHId { get; set; }
        public int PerVchrDId { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string PerVchrDTx { get; set; }
        public decimal PerVchrDDebit { get; set; }
        public decimal PerVchrDCredit { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public DateTime? PerVchrHDate { get; set; }
        public DateTime? PerVchrHDateFrom { get; set; }
        public DateTime? PerVchrHDateUntil { get; set; }
        public string PerVchrHTx { get; set; }
        public bool? PerVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public string PerVchrDDate { get; set; }
        public decimal? PerVchrDDebitC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public decimal? PerVchrDCreditC { get; set; }
        public string CtbCurncyTp { get; set; }
        public string AccLpTp2 { get; set; }
        public string AccLcTp2 { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public int? AccLtCu2 { get; set; }
        public string AccLtTp2 { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLmTp2 { get; set; }
        public string AccLkTp2 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalVchrD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalVchrHId { get; set; }
        public int SalVchrDId { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string SalVchrDTx { get; set; }
        public decimal SalVchrDDebit { get; set; }
        public decimal SalVchrDCredit { get; set; }
        public DateTime SalVchrHDate { get; set; }
        public DateTime SalVchrHDateFrom { get; set; }
        public DateTime SalVchrHDateUntil { get; set; }
        public string SalVchrHTx { get; set; }
        public bool? SalVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public int? CorrectionCount { get; set; }
        public int SalVchrDReferenceId { get; set; }
        public int SalVchrDType { get; set; }
        public int? SalVchrHRow { get; set; }
        public decimal? SalVchrDDebitC { get; set; }
        public decimal? SalVchrDCreditC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public string CtbCurncyTp { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLmTp2 { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLtTp2 { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLcTp2 { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public string AccLpTp2 { get; set; }
    }
}

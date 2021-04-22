using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvVchrD: DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvVchrHId { get; set; }
        public int InvVchrDId { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string InvVchrDTx { get; set; }
        public decimal InvVchrDDebit { get; set; }
        public decimal InvVchrDCredit { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public DateTime? InvVchrHDate { get; set; }
        public DateTime? InvVchrHDateFrom { get; set; }
        public DateTime? InvVchrHDateUntil { get; set; }
        public string InvVchrHTx { get; set; }
        public bool InvVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public int? CuDoc { get; set; }
        public DateTime? DsDoc { get; set; }
        public string InvVchrDDate { get; set; }
        public decimal? InvVchrDDebitC { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? ExchangeRate { get; set; }
        public decimal? InvVchrDCreditC { get; set; }
        public string CtbCurncyTp { get; set; }
        public string AccLpTp2 { get; set; }
        public string AccLcTp2 { get; set; }
        public string AccLmTp2 { get; set; }
        public string AccLkTp2 { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLtTp2 { get; set; }
    }
}

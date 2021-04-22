using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPaySummery : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPaySummerySi { get; set; }
        public int? PerPayerHSi { get; set; }
        public int? PerPyrlPeriodSi { get; set; }
        public double? PerPaySummerySum1Now { get; set; }
        public double? PerPaySummerySum2Now { get; set; }
        public double? PerPaySummeryTax { get; set; }
        public double? PerPaySummerySum1Pre { get; set; }
        public double? PerPaySummerySum2Pre { get; set; }
        public double? PerPaySummeryPenalty1 { get; set; }
        public double? PerPaySummeryPenalty1Pre { get; set; }
        public double? PerPaySummeryPenalty2 { get; set; }
        public double? PerPaySummeryPenaltyPre { get; set; }
        public double? PerPaySummeryTaxDebitNow { get; set; }
        public double? PerPaySummeryTaxDebitPre { get; set; }
        public string PerPaySummeryDateInsu { get; set; }
        public int? PerPaySummeryNumPer { get; set; }
        public int? PerPaySummeryForNumPer { get; set; }
        public string PerPaySummeryPayType { get; set; }
        public double? PerPaySummerySumTaxNow { get; set; }
        public double? PerPaySummerySumTaxPre { get; set; }
        public string PerPaySummeryChpDate { get; set; }
        public string PerPaySummeryChpAccNo { get; set; }
        public string PerPaySummeryChpBankName { get; set; }
        public string PerPaySummeryChpBrnchName { get; set; }
        public double? PerPaySummeryTaxPay { get; set; }
        public int? PerPaySummeryPayTypIn { get; set; }
        public int? PerTaxGrpSi { get; set; }
        public int? CtbBankSi { get; set; }
        public string PerPaySummeryChpNo { get; set; }
        public int? PerPaidTypeSi { get; set; }
        public decimal? PerPaySummeryCheqPrice { get; set; }
        public string PerPaySummeryPayDate { get; set; }
        public int? PerPaymentTypeSi { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsDcA : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDcCSi { get; set; }
        public int TrsDcASi { get; set; }
        public int? TrsRsrcSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string TrsDcATp { get; set; }
        public decimal TrsDcADebit { get; set; }
        public decimal TrsDcACredit { get; set; }
        public short TrsStsSi { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public DateTime? TrsDcCDt { get; set; }
        public int? TrsAsgnSi { get; set; }
        public string TrsRsrcTp { get; set; }
        public int? TrsDcSSi { get; set; }
        public DateTime? TrsDcSDt { get; set; }
        public DateTime TrsDcDt { get; set; }
        public short TrsDcTypSi { get; set; }
        public short TrsCtypSi { get; set; }
        public byte? TrsDcSMnthSi { get; set; }
        public byte? TrsDcMnthSi { get; set; }
        public double? TrsDcCIno { get; set; }
        public string TrsDcCIbnk { get; set; }
        public string TrsDcCIbrnch { get; set; }
        public string TrsDcCIaccNo { get; set; }
        public string TrsStsTp { get; set; }
        public int? TrsDcCu { get; set; }
        public string TrsCtypTp { get; set; }
        public int? AccDocHSi { get; set; }
        public int TrsDcSi { get; set; }
        public string TrsDcAAccDesc { get; set; }
        public double TrsDcCDebitC { get; set; }
        public double TrsDcCCreditC { get; set; }
        public string TrsDcCRfrnc { get; set; }
        public double TrsDcADebitC { get; set; }
        public double TrsDcACreditC { get; set; }
        public int? SiDocType { get; set; }
        public string TrsDcARfrnc { get; set; }
        public string TrsDcACuDoc { get; set; }
        public string TrsCtypTp2 { get; set; }
        public string TrsStsTp2 { get; set; }
        public string AccLmTp2 { get; set; }
        public string AccLtTp2 { get; set; }
        public string TpCost2 { get; set; }
        public string TpProject2 { get; set; }
        public double? ExchangeRate { get; set; }
        public int? CtbCurncySi { get; set; }
        public string CtbCurncyTp { get; set; }
        public int? TrsAordrSi { get; set; }
        public bool? TrsDcAFirstCu { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? TrsDcCu2 { get; set; }
        public int? SecCuDoc { get; set; }
        public double? DebitC { get; set; }
        public double? CreditC { get; set; }
        public int HasTrsDcCattach { get; set; }
        public int HasTrsDcAttach { get; set; }
        public string SalIntrmdCu { get; set; }
        public string SalIntrmdTp { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsVchr : DinawinBaseEntity, IMyEntityDinawin
    {
        public byte? DtmonthNo { get; set; }
        public DateTime? Dt { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string Tp { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? TrsDcCSi { get; set; }
        public int? TrsRsrcSi { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLmTp2 { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLtTp2 { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public string TrsRsrcTp { get; set; }
        public int TrsStsSi { get; set; }
        public short TrsDcTypSi { get; set; }
        public short? TrsCtypSi { get; set; }
        public byte? CtbMnthSi { get; set; }
        public double? TrsDcCIno { get; set; }
        public DateTime? TrsDcCDt { get; set; }
        public string TrsDcCIbnk { get; set; }
        public string TrsDcCIbrnch { get; set; }
        public string TrsDcCIaccNo { get; set; }
        public string TrsStsTp { get; set; }
        public string TrsStsTp2 { get; set; }
        public int? TrsDcCu { get; set; }
        public string TrsCtypTp { get; set; }
        public string TrsCtypTp2 { get; set; }
        public int? AccDocHSi { get; set; }
        public int? TrsDcASi { get; set; }
        public int TrsDcSi { get; set; }
        public string AccDesc { get; set; }
        public int? TrsDcSSi { get; set; }
        public string TrsDcCRfrnc { get; set; }
        public double? CreditC { get; set; }
        public double? DebitC { get; set; }
        public double? ExchangeRate { get; set; }
        public string CtbCurncyTp { get; set; }
        public int? CtbCurncySi { get; set; }
        public int? SiDocType { get; set; }
        public int? TrsRsrcSiC { get; set; }
        public string StmpCus { get; set; }
        public string TrsDcCCuDoc { get; set; }
        public string TrsDcCAccDesc { get; set; }
        public string TrsDcCForMoney { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SecCuDoc { get; set; }
        public double? DebitCc { get; set; }
        public double? CreditCc { get; set; }
        public int HasTrsDcCattach { get; set; }
        public int HasTrsDcAttach { get; set; }
        public string SalIntrmdTp { get; set; }
        public string TrsAsgnAccTTp { get; set; }
        public string TrsDcCInoh { get; set; }
        public string TrsDcCInon { get; set; }
    }
}

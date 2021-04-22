using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDcC : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDcCSi { get; set; }
        public int TrsDcSi { get; set; }
        public DateTime? TrsDcCDt { get; set; }
        public short TrsCtypSi { get; set; }
        public short TrsStsSi { get; set; }
        public int TrsRsrcSi { get; set; }
        public decimal TrsDcCDebit { get; set; }
        public decimal TrsDcCCredit { get; set; }
        public int? TrsChqPSi { get; set; }
        public double? TrsDcCIno { get; set; }
        public string TrsDcCIbnk { get; set; }
        public string TrsDcCIbrnch { get; set; }
        public string TrsDcCIaccNo { get; set; }
        public string TrsDcCTp { get; set; }
        public byte? CtbMnthSi { get; set; }
        public string TrsDcCAccDesc { get; set; }
        public int? AccDocHSi { get; set; }
        public int? TrsAordrSi { get; set; }
        public double TrsDcCDebitC { get; set; }
        public double TrsDcCCreditC { get; set; }
        public string TrsDcCRfrnc { get; set; }
        public double? ExchangeRate { get; set; }
        public int? CtbCurncySi { get; set; }
        public int? SiDocType { get; set; }
        public string TrsDcCForMoney { get; set; }
        public string Id { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public DateTime? TrsDcCDt2 { get; set; }
        public string TrsDcCInoh { get; set; }
        public string TrsDcCInon { get; set; }
        public string TrsDcCBrnchNo { get; set; }
        public string TrsDcCCuDoc { get; set; }
        public string TrsDccIntrmd { get; set; }
        public bool? TrsDccFirstCu { get; set; }
        public int? SecCuDoc { get; set; }
        public double? DebitC { get; set; }
        public double? CreditC { get; set; }

        public virtual TrsAordr TrsAordrSiNavigation { get; set; }
        public virtual TrsCtyp TrsCtypSiNavigation { get; set; }
        public virtual TrsDc TrsDcSiNavigation { get; set; }
        public virtual TrsRsrc TrsRsrcSiNavigation { get; set; }
    }
}

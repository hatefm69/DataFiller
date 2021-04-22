using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsAnlyz : DinawinBaseEntity, IMyEntityDinawin
    {
        public DateTime? Dt { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string Tp { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public int TrsDcCSi { get; set; }
        public int TrsRsrcSi { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public int? AccLcCu { get; set; }
        public int? AccLcTp { get; set; }
        public int? AccLpCu { get; set; }
        public int? AccLpTp { get; set; }
        public string TrsRsrcTp { get; set; }
        public int TrsStsSi { get; set; }
        public short TrsDcTypSi { get; set; }
        public short TrsCtypSi { get; set; }
        public byte? CtbMnthSi { get; set; }
        public double? TrsDcCIno { get; set; }
        public DateTime? TrsDcCDt { get; set; }
        public string TrsDcCIbnk { get; set; }
        public string TrsDcCIbrnch { get; set; }
        public string TrsDcCIaccNo { get; set; }
        public string TrsStsTp { get; set; }
        public int? TrsDcCu { get; set; }
        public string TrsCtypTp { get; set; }
        public int? AccDocHSi { get; set; }
        public int? TrsDcASi { get; set; }
        public int TrsDcSi { get; set; }
        public string AccDesc { get; set; }
        public int? TrsDcSSi { get; set; }
        public string TrsDcCRfrnc { get; set; }
        public double DebitC { get; set; }
        public double CreditC { get; set; }
    }
}

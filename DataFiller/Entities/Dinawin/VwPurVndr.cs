using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurVndr: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurVndrSi { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? PurVndrGrpSi { get; set; }
        public string PurVndrGrpCu { get; set; }
        public string PurVndrGrpTp { get; set; }
        public int? AccTSi { get; set; }
        public int? AccMSi1 { get; set; }
        public string CtbAddrsDesc { get; set; }
        public string CtbAddrsPobox { get; set; }
        public string CtbAddrsZipcode { get; set; }
        public string CtbAddrsTel { get; set; }
        public string CtbAddrsMobile { get; set; }
        public string CtbAddrsFax { get; set; }
        public string CtbAddrsModem { get; set; }
        public string CtbAddrsAddrs { get; set; }
        public bool? CtbAddrsDefault { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public short? PurVndrCorporateTyp { get; set; }
        public short? CtbCustVndrTypSi { get; set; }
        public string CtbCustVndrTypTp { get; set; }
        public string PurVndrCorporateTypTp { get; set; }
        public int? PurVndrScore { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string CtbAddrsEconamical { get; set; }
        public string CtbAddrsNatCode { get; set; }
        public int? CtbAddrsSi { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public string CtbAddrsEmail { get; set; }
        public double? CtbAddrsMajor { get; set; }
        public string CtbAddrsContact { get; set; }
        public string CtbAddrsPersonality { get; set; }
        public string CtbAddrsCity { get; set; }
        public string CtbAddrsOstan { get; set; }
        public string CtbAddrsShahrestan { get; set; }
        public int? CtbAddrsNumber { get; set; }
        public string PurVndrComment { get; set; }
    }
}

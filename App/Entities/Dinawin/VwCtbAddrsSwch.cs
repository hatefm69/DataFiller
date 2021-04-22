using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwCtbAddrsSwch : DinawinBaseEntity, IMyEntityDinawin
    {
        public string CtbAddrsSwchTbl { get; set; }
        public int CtbAddrsSwchTblSi { get; set; }
        public int? CtbAddrsSi { get; set; }
        public string CtbAddrsDesc { get; set; }
        public string CtbAddrsPobox { get; set; }
        public string CtbAddrsZipcode { get; set; }
        public string CtbAddrsTel { get; set; }
        public string CtbAddrsMobile { get; set; }
        public string CtbAddrsFax { get; set; }
        public string CtbAddrsModem { get; set; }
        public string CtbAddrsAddrs { get; set; }
        public string CtbAddrsEmail { get; set; }
        public bool? CtbAddrsDefault { get; set; }
        public double? CtbAddrsMajor { get; set; }
        public string CtbAddrsContact { get; set; }
        public string CtbAddrsPersonality { get; set; }
        public bool? CtbAddrsAdvetise { get; set; }
        public string CtbAddrsOwn { get; set; }
        public int? SalCustStLook { get; set; }
        public string CtbAddrsPersonSkill { get; set; }
        public string CtbAddrsAdvetiseDesc { get; set; }
        public int? CtbAddrsMtr { get; set; }
        public string CtbAddrsLicenseCode { get; set; }
        public string CtbAddrsActiveType { get; set; }
        public string CtbAddrsBankName { get; set; }
        public string CtbAddrsBranch { get; set; }
        public string CtbAddrsCode { get; set; }
        public string CtbAddrsAccountNo { get; set; }
        public string CtbAddrsAccountName { get; set; }
        public string CtbAddrsNatCode { get; set; }
        public string CtbAddrsEconamical { get; set; }
        public string CtbAddrsCity { get; set; }
        public string CtbAddrsOstan { get; set; }
        public string CtbAddrsShahrestan { get; set; }
        public bool? CtbAddrsShowPrint { get; set; }
        public bool? CtbAddrsDefault2 { get; set; }
        public string CtbAddrsInterduced { get; set; }
        public string CtbAddrsDsFirst { get; set; }
        public string CtbAddrsRelated { get; set; }
        public string CtbAddrsEnterduced { get; set; }
        public int? SalCountrySi { get; set; }
        public int? SalProvinceSi { get; set; }
        public int? SalCitySi { get; set; }
        public int? CtbAddrsNumber { get; set; }
    }
}

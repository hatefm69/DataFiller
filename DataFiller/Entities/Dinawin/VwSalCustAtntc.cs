using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalCustAtntc: DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalCustAtntcSi { get; set; }
        public int SalCustSi { get; set; }
        public string SalCustAtntcDs { get; set; }
        public decimal SalCustAtntcPrice { get; set; }
        public byte SalCustAtntcTyp { get; set; }
        public bool SalCustAtntcActv { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public string SalCustGrpTp { get; set; }
        public string SalCustGrpCu { get; set; }
        public string CtbAddrsAddrs { get; set; }
        public string CtbAddrsTel { get; set; }
        public string CtbAddrsFax { get; set; }
        public string CtbAddrsEmail { get; set; }
        public int SalCustGrpSi { get; set; }
        public int? SalRegionSi { get; set; }
        public string SalRegionTp { get; set; }
        public int? SalRegionPathSi { get; set; }
        public string SalRegionPathTp { get; set; }
        public int? SalCustAtntcSaleType { get; set; }
    }
}

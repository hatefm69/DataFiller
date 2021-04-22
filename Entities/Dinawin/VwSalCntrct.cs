using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalCntrct: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SalContractHCu { get; set; }
        public int? SalContractTypeId { get; set; }
        public int SalCustSi { get; set; }
        public string State { get; set; }
        public string SalContractNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public decimal? SalContractPrcTotal { get; set; }
        public string SalContractTp { get; set; }
        public int SalContractHSi { get; set; }
        public string SalCntrctHDs { get; set; }
        public string SalCustTp { get; set; }
        public string CtbAddrsPobox { get; set; }
        public string CtbAddrsZipcode { get; set; }
        public string CtbAddrsTel { get; set; }
        public string CtbAddrsFax { get; set; }
        public string CtbAddrsAddrs { get; set; }
        public string SalCustCu { get; set; }
        public int? SalCustGrpSi { get; set; }
        public string SalCustGrpCu { get; set; }
        public string SalCustGrpTp { get; set; }
        public int? AccTSi { get; set; }
        public int? AccMSi { get; set; }
        public int? SalRegionSi { get; set; }
        public string SalRegionTp { get; set; }
        public int? SalCustStatusSi { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalAdmitCust : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalAdmitCustSi { get; set; }
        public string SalAdmitCustTp { get; set; }
        public string SalAdmitCustProducts { get; set; }
        public int? SalAdmitStatusSi { get; set; }
        public bool? SalAdmitCustNeedsGift { get; set; }
        public string SalAdmitCustUtiliseDate { get; set; }
        public string SalAdmitCustDesc { get; set; }
        public int? SalCustSi { get; set; }
        public string SalAdmitCustDateEnter { get; set; }
        public string SalAdmitCustDateEdit { get; set; }
        public string SalAdmitCustUserEnter { get; set; }
        public string SalAdmitCustUserEdit { get; set; }
        public string SalAdmitCustGoodsNeed { get; set; }
        public string SalAdmitCustInterView { get; set; }
        public string SalAdmitCustSummery { get; set; }
        public bool? SalAdmitCustNeedSearch { get; set; }
        public string SalAdmitCustDateSearch { get; set; }
        public bool? SalAdmitCustNotNeedSearch { get; set; }
        public string SalAdmitCustNotSearchReason { get; set; }
        public string SalAdmitCustGoodsarzyabi { get; set; }
        public string SalAdmitCustEarnInfo { get; set; }

        public virtual SalCust SalCustSiNavigation { get; set; }
    }
}

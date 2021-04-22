using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCust : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalCust()
        {
            AssReceiptH = new HashSet<AssReceiptH>();
            InvGdsGrant = new HashSet<InvGdsGrant>();
            SalAdmitCust = new HashSet<SalAdmitCust>();
            SalContractH = new HashSet<SalContractH>();
            SalCustAtntc = new HashSet<SalCustAtntc>();
            SalDepend = new HashSet<SalDepend>();
            SalInvcH = new HashSet<SalInvcH>();
            SalInvcSrvH = new HashSet<SalInvcSrvH>();
            SalPreInvcH = new HashSet<SalPreInvcH>();
            SalPreInvcSrvH = new HashSet<SalPreInvcSrvH>();
            SalPursue = new HashSet<SalPursue>();
            SalRequestH = new HashSet<SalRequestH>();
            SalRetInvcH = new HashSet<SalRetInvcH>();
            SalePreInvoice = new HashSet<SalePreInvoice>();
        }

        public int SalCustSi { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public int SalCustGrpSi { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalRegionSi { get; set; }
        public int? SalRegionPathSi { get; set; }
        public int? SalCustStatusSi { get; set; }
        public bool? RplFlag { get; set; }
        public int? SalCustStLook { get; set; }
        public short? SalCustCorporateTyp { get; set; }
        public int? CtbCustVndrTypSi { get; set; }
        public string SalCustUser { get; set; }
        public bool? SalCustActive { get; set; }
        public string SalCustDesc { get; set; }
        public string SalCustReasongust { get; set; }
        public string SalCustProduceNow { get; set; }
        public int? SalCustDivision { get; set; }
        public bool? SalCustPursuit { get; set; }
        public string SalCustPursuitTp { get; set; }
        public string SalcustAdvetiseDesc { get; set; }
        public int? SalcustMtr { get; set; }
        public string SalcustLicenseCode { get; set; }
        public bool? SalcustAdvetise { get; set; }
        public string SalcustActiveType { get; set; }
        public string SalcustOwn { get; set; }
        public double? SalcustMajor { get; set; }
        public string SalcustDsFirst { get; set; }
        public string SalcustEnterduced { get; set; }
        public string SalcustPersonSkill { get; set; }
        public string SalcustContact { get; set; }
        public string SalcustRelated { get; set; }
        public string SalCustDateEnter { get; set; }
        public int? SalEnterducedSi { get; set; }
        public string SalcustJob { get; set; }
        public string SalCustDateSave { get; set; }
        public int? SalCustActiveTypSi { get; set; }
        public bool? SalCustNeesSearch { get; set; }
        public bool? SalCustBlackList { get; set; }
        public string SalCustTitle { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public int? SalvarietySi { get; set; }
        public string SalAdmitCustDateEnter { get; set; }
        public string SalAdmitCustDateSearch { get; set; }
        public bool? SalAdmitCustNotNeedSearch { get; set; }
        public string SalAdmitCustGoodsNeed { get; set; }
        public int? SalAdmitStatusSi { get; set; }
        public bool? SalAdmitCustNeedsGift { get; set; }
        public string SalAdmitCustDesc { get; set; }
        public string SalAdmitCustUtiliseDate { get; set; }
        public string SalCustDomain { get; set; }
        public string SalCustUserPursueInsert { get; set; }
        public string SalCustUserPursueUpdate { get; set; }

        public virtual CtbAccM AccMSiNavigation { get; set; }
        public virtual CtbAccT AccTSiNavigation { get; set; }
        public virtual CtbCustVndrTyp CtbCustVndrTypSiNavigation { get; set; }
        public virtual SalBrnch SalBrnchSiNavigation { get; set; }
        public virtual SalCustActiveTyp SalCustActiveTypSiNavigation { get; set; }
        public virtual SalDivision SalCustDivisionNavigation { get; set; }
        public virtual SalCustGrp SalCustGrpSiNavigation { get; set; }
        public virtual SalCustStatus SalCustStatusSiNavigation { get; set; }
        public virtual SalEnterduced SalEnterducedSiNavigation { get; set; }
        public virtual SalIntrmd SalIntrmdSiNavigation { get; set; }
        public virtual ICollection<AssReceiptH> AssReceiptH { get; set; }
        public virtual ICollection<InvGdsGrant> InvGdsGrant { get; set; }
        public virtual ICollection<SalAdmitCust> SalAdmitCust { get; set; }
        public virtual ICollection<SalContractH> SalContractH { get; set; }
        public virtual ICollection<SalCustAtntc> SalCustAtntc { get; set; }
        public virtual ICollection<SalDepend> SalDepend { get; set; }
        public virtual ICollection<SalInvcH> SalInvcH { get; set; }
        public virtual ICollection<SalInvcSrvH> SalInvcSrvH { get; set; }
        public virtual ICollection<SalPreInvcH> SalPreInvcH { get; set; }
        public virtual ICollection<SalPreInvcSrvH> SalPreInvcSrvH { get; set; }
        public virtual ICollection<SalPursue> SalPursue { get; set; }
        public virtual ICollection<SalRequestH> SalRequestH { get; set; }
        public virtual ICollection<SalRetInvcH> SalRetInvcH { get; set; }
        public virtual ICollection<SalePreInvoice> SalePreInvoice { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAccM : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbAccM()
        {
            AccArqst = new HashSet<AccArqst>();
            AccBudget = new HashSet<AccBudget>();
            AccCtbMinfo = new HashSet<AccCtbMinfo>();
            AccCtbMinfoDefault = new HashSet<AccCtbMinfoDefault>();
            AccDdoc = new HashSet<AccDdoc>();
            AstAssetSellingAccMastGrpSiNavigation = new HashSet<AstAssetSelling>();
            AstAssetSellingAccMbankSiNavigation = new HashSet<AstAssetSelling>();
            AstAssetSellingAccMbenfSiNavigation = new HashSet<AstAssetSelling>();
            AstAssetSellingAccMdeprSiNavigation = new HashSet<AstAssetSelling>();
            BgtAccIntro = new HashSet<BgtAccIntro>();
            BgtAssignAccM = new HashSet<BgtAssignAccM>();
            BgtChangeCostD = new HashSet<BgtChangeCostD>();
            CtbAccT2ctbAccM = new HashSet<CtbAccT2ctbAccM>();
            CtbCost2CtbAccM = new HashSet<CtbCost2CtbAccM>();
            CtbPrj2CtbAccM = new HashSet<CtbPrj2CtbAccM>();
            InvDocD = new HashSet<InvDocD>();
            InvGdsAccC = new HashSet<InvGdsAccC>();
            InvGdsAccP = new HashSet<InvGdsAccP>();
            InvVchrCodeMap = new HashSet<InvVchrCodeMap>();
            InvVchrD = new HashSet<InvVchrD>();
            PerOpr = new HashSet<PerOpr>();
            PerVchrD = new HashSet<PerVchrD>();
            PurVndr = new HashSet<PurVndr>();
            SalCust = new HashSet<SalCust>();
            SalCustFrmul = new HashSet<SalCustFrmul>();
            SalGdsAcc = new HashSet<SalGdsAcc>();
            SalGdsRetAcc = new HashSet<SalGdsRetAcc>();
            SalInvcOpr = new HashSet<SalInvcOpr>();
            SalInvcSrvOpr = new HashSet<SalInvcSrvOpr>();
            SalOpr = new HashSet<SalOpr>();
            SalPreInvcSrvOpr = new HashSet<SalPreInvcSrvOpr>();
            SalRetInvcOpr = new HashSet<SalRetInvcOpr>();
            SalSrvAcc = new HashSet<SalSrvAcc>();
            SalVchrD = new HashSet<SalVchrD>();
            TrsAcc = new HashSet<TrsAcc>();
            TrsArqst = new HashSet<TrsArqst>();
            TrsAsgn = new HashSet<TrsAsgn>();
            TrsDcA = new HashSet<TrsDcA>();
            TrsRsrcAccLmSi2Navigation = new HashSet<TrsRsrc>();
            TrsRsrcAccLmSiNavigation = new HashSet<TrsRsrc>();
            TrsVchrD = new HashSet<TrsVchrD>();
        }

        public int SiAccM { get; set; }
        public int SiAccK { get; set; }
        public string CuAcc { get; set; }
        public string TpAcc { get; set; }
        public DateTime CreateRec { get; set; }
        public string LoginName { get; set; }
        public bool? ConWithAccT { get; set; }
        public bool? ConWithCost { get; set; }
        public bool? ConWithProject { get; set; }
        public int Nature { get; set; }
        public byte Type { get; set; }
        public bool? RqstAccT { get; set; }
        public bool? RqstCost { get; set; }
        public bool? RqstProject { get; set; }
        public bool? SysTrs { get; set; }
        public byte NatureCtrl { get; set; }
        public string TpAcc2 { get; set; }
        public bool? RqstRfrnc { get; set; }
        public bool? RqstCurrncy { get; set; }
        public int? CuAcc2 { get; set; }
        public bool? ExchangeFlag { get; set; }
        public int? Status { get; set; }
        public int? SiFather { get; set; }
        public string CmAcc { get; set; }
        public bool? RqstShowInSale { get; set; }
        public bool? RqstShowInSaleCredit { get; set; }
        public bool? RqstHasInfo { get; set; }
        public bool? RqstInfo { get; set; }

        public virtual CtbAccK SiAccKNavigation { get; set; }
        public virtual ICollection<AccArqst> AccArqst { get; set; }
        public virtual ICollection<AccBudget> AccBudget { get; set; }
        public virtual ICollection<AccCtbMinfo> AccCtbMinfo { get; set; }
        public virtual ICollection<AccCtbMinfoDefault> AccCtbMinfoDefault { get; set; }
        public virtual ICollection<AccDdoc> AccDdoc { get; set; }
        public virtual ICollection<AstAssetSelling> AstAssetSellingAccMastGrpSiNavigation { get; set; }
        public virtual ICollection<AstAssetSelling> AstAssetSellingAccMbankSiNavigation { get; set; }
        public virtual ICollection<AstAssetSelling> AstAssetSellingAccMbenfSiNavigation { get; set; }
        public virtual ICollection<AstAssetSelling> AstAssetSellingAccMdeprSiNavigation { get; set; }
        public virtual ICollection<BgtAccIntro> BgtAccIntro { get; set; }
        public virtual ICollection<BgtAssignAccM> BgtAssignAccM { get; set; }
        public virtual ICollection<BgtChangeCostD> BgtChangeCostD { get; set; }
        public virtual ICollection<CtbAccT2ctbAccM> CtbAccT2ctbAccM { get; set; }
        public virtual ICollection<CtbCost2CtbAccM> CtbCost2CtbAccM { get; set; }
        public virtual ICollection<CtbPrj2CtbAccM> CtbPrj2CtbAccM { get; set; }
        public virtual ICollection<InvDocD> InvDocD { get; set; }
        public virtual ICollection<InvGdsAccC> InvGdsAccC { get; set; }
        public virtual ICollection<InvGdsAccP> InvGdsAccP { get; set; }
        public virtual ICollection<InvVchrCodeMap> InvVchrCodeMap { get; set; }
        public virtual ICollection<InvVchrD> InvVchrD { get; set; }
        public virtual ICollection<PerOpr> PerOpr { get; set; }
        public virtual ICollection<PerVchrD> PerVchrD { get; set; }
        public virtual ICollection<PurVndr> PurVndr { get; set; }
        public virtual ICollection<SalCust> SalCust { get; set; }
        public virtual ICollection<SalCustFrmul> SalCustFrmul { get; set; }
        public virtual ICollection<SalGdsAcc> SalGdsAcc { get; set; }
        public virtual ICollection<SalGdsRetAcc> SalGdsRetAcc { get; set; }
        public virtual ICollection<SalInvcOpr> SalInvcOpr { get; set; }
        public virtual ICollection<SalInvcSrvOpr> SalInvcSrvOpr { get; set; }
        public virtual ICollection<SalOpr> SalOpr { get; set; }
        public virtual ICollection<SalPreInvcSrvOpr> SalPreInvcSrvOpr { get; set; }
        public virtual ICollection<SalRetInvcOpr> SalRetInvcOpr { get; set; }
        public virtual ICollection<SalSrvAcc> SalSrvAcc { get; set; }
        public virtual ICollection<SalVchrD> SalVchrD { get; set; }
        public virtual ICollection<TrsAcc> TrsAcc { get; set; }
        public virtual ICollection<TrsArqst> TrsArqst { get; set; }
        public virtual ICollection<TrsAsgn> TrsAsgn { get; set; }
        public virtual ICollection<TrsDcA> TrsDcA { get; set; }
        public virtual ICollection<TrsRsrc> TrsRsrcAccLmSi2Navigation { get; set; }
        public virtual ICollection<TrsRsrc> TrsRsrcAccLmSiNavigation { get; set; }
        public virtual ICollection<TrsVchrD> TrsVchrD { get; set; }
    }
}

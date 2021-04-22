using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAccT : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbAccT()
        {
            AccArqst = new HashSet<AccArqst>();
            AccBudget = new HashSet<AccBudget>();
            AccDdoc = new HashSet<AccDdoc>();
            AstAssetSelling = new HashSet<AstAssetSelling>();
            CtbAccT2ctbAccM = new HashSet<CtbAccT2ctbAccM>();
            InvDocD = new HashSet<InvDocD>();
            InvGdsAccC = new HashSet<InvGdsAccC>();
            InvGdsAccP = new HashSet<InvGdsAccP>();
            InvInvt = new HashSet<InvInvt>();
            InvVchrCodeMap = new HashSet<InvVchrCodeMap>();
            InvVchrD = new HashSet<InvVchrD>();
            PerOpr = new HashSet<PerOpr>();
            PerPrsnlD = new HashSet<PerPrsnlD>();
            PerVchrD = new HashSet<PerVchrD>();
            PurVndr = new HashSet<PurVndr>();
            SalCust = new HashSet<SalCust>();
            SalGdsAcc = new HashSet<SalGdsAcc>();
            SalGdsRetAcc = new HashSet<SalGdsRetAcc>();
            SalInvcOpr = new HashSet<SalInvcOpr>();
            SalInvcSrvOpr = new HashSet<SalInvcSrvOpr>();
            SalOpr = new HashSet<SalOpr>();
            SalPreInvcSrvOpr = new HashSet<SalPreInvcSrvOpr>();
            SalRetInvcOpr = new HashSet<SalRetInvcOpr>();
            SalSrvAcc = new HashSet<SalSrvAcc>();
            TrsAcc = new HashSet<TrsAcc>();
            TrsArqst = new HashSet<TrsArqst>();
            TrsAsgn = new HashSet<TrsAsgn>();
            TrsChqP = new HashSet<TrsChqP>();
            TrsDcA = new HashSet<TrsDcA>();
            TrsRsrc = new HashSet<TrsRsrc>();
            TrsVchrD = new HashSet<TrsVchrD>();
        }

        public int SiAccT { get; set; }
        public string CuAcc { get; set; }
        public string TpAcc { get; set; }
        public int SiFather { get; set; }
        public string CmAcc { get; set; }
        public DateTime? CreateRec { get; set; }
        public string LoginName { get; set; }
        public string TpAcc2 { get; set; }
        public int? CuAcc2 { get; set; }
        public int? Nature { get; set; }

        public virtual ICollection<AccArqst> AccArqst { get; set; }
        public virtual ICollection<AccBudget> AccBudget { get; set; }
        public virtual ICollection<AccDdoc> AccDdoc { get; set; }
        public virtual ICollection<AstAssetSelling> AstAssetSelling { get; set; }
        public virtual ICollection<CtbAccT2ctbAccM> CtbAccT2ctbAccM { get; set; }
        public virtual ICollection<InvDocD> InvDocD { get; set; }
        public virtual ICollection<InvGdsAccC> InvGdsAccC { get; set; }
        public virtual ICollection<InvGdsAccP> InvGdsAccP { get; set; }
        public virtual ICollection<InvInvt> InvInvt { get; set; }
        public virtual ICollection<InvVchrCodeMap> InvVchrCodeMap { get; set; }
        public virtual ICollection<InvVchrD> InvVchrD { get; set; }
        public virtual ICollection<PerOpr> PerOpr { get; set; }
        public virtual ICollection<PerPrsnlD> PerPrsnlD { get; set; }
        public virtual ICollection<PerVchrD> PerVchrD { get; set; }
        public virtual ICollection<PurVndr> PurVndr { get; set; }
        public virtual ICollection<SalCust> SalCust { get; set; }
        public virtual ICollection<SalGdsAcc> SalGdsAcc { get; set; }
        public virtual ICollection<SalGdsRetAcc> SalGdsRetAcc { get; set; }
        public virtual ICollection<SalInvcOpr> SalInvcOpr { get; set; }
        public virtual ICollection<SalInvcSrvOpr> SalInvcSrvOpr { get; set; }
        public virtual ICollection<SalOpr> SalOpr { get; set; }
        public virtual ICollection<SalPreInvcSrvOpr> SalPreInvcSrvOpr { get; set; }
        public virtual ICollection<SalRetInvcOpr> SalRetInvcOpr { get; set; }
        public virtual ICollection<SalSrvAcc> SalSrvAcc { get; set; }
        public virtual ICollection<TrsAcc> TrsAcc { get; set; }
        public virtual ICollection<TrsArqst> TrsArqst { get; set; }
        public virtual ICollection<TrsAsgn> TrsAsgn { get; set; }
        public virtual ICollection<TrsChqP> TrsChqP { get; set; }
        public virtual ICollection<TrsDcA> TrsDcA { get; set; }
        public virtual ICollection<TrsRsrc> TrsRsrc { get; set; }
        public virtual ICollection<TrsVchrD> TrsVchrD { get; set; }
    }
}

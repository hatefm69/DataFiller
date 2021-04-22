using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbProject : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbProject()
        {
            AccArqst = new HashSet<AccArqst>();
            AccBudget = new HashSet<AccBudget>();
            AccDdoc = new HashSet<AccDdoc>();
            BgtAssignToPrj = new HashSet<BgtAssignToPrj>();
            CtbPrj2CtbAccM = new HashSet<CtbPrj2CtbAccM>();
            InvDocD = new HashSet<InvDocD>();
            InvGdsAccP = new HashSet<InvGdsAccP>();
            InvInvt = new HashSet<InvInvt>();
            InvVchrCodeMap = new HashSet<InvVchrCodeMap>();
            InvVchrD = new HashSet<InvVchrD>();
            PerVchrD = new HashSet<PerVchrD>();
            SalVchrD = new HashSet<SalVchrD>();
            TrsAcc = new HashSet<TrsAcc>();
            TrsArqst = new HashSet<TrsArqst>();
            TrsAsgn = new HashSet<TrsAsgn>();
            TrsDcA = new HashSet<TrsDcA>();
            TrsVchrD = new HashSet<TrsVchrD>();
        }

        public int SiProject { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public int? SiFather { get; set; }
        public DateTime CreateRec { get; set; }
        public string LoginName { get; set; }
        public int? SiHsrlDoc { get; set; }
        public string TpProject2 { get; set; }
        public string CuProject2 { get; set; }
        public string DsBondPrsnl { get; set; }
        public string DsBondPrsnlTo { get; set; }

        public virtual ICollection<AccArqst> AccArqst { get; set; }
        public virtual ICollection<AccBudget> AccBudget { get; set; }
        public virtual ICollection<AccDdoc> AccDdoc { get; set; }
        public virtual ICollection<BgtAssignToPrj> BgtAssignToPrj { get; set; }
        public virtual ICollection<CtbPrj2CtbAccM> CtbPrj2CtbAccM { get; set; }
        public virtual ICollection<InvDocD> InvDocD { get; set; }
        public virtual ICollection<InvGdsAccP> InvGdsAccP { get; set; }
        public virtual ICollection<InvInvt> InvInvt { get; set; }
        public virtual ICollection<InvVchrCodeMap> InvVchrCodeMap { get; set; }
        public virtual ICollection<InvVchrD> InvVchrD { get; set; }
        public virtual ICollection<PerVchrD> PerVchrD { get; set; }
        public virtual ICollection<SalVchrD> SalVchrD { get; set; }
        public virtual ICollection<TrsAcc> TrsAcc { get; set; }
        public virtual ICollection<TrsArqst> TrsArqst { get; set; }
        public virtual ICollection<TrsAsgn> TrsAsgn { get; set; }
        public virtual ICollection<TrsDcA> TrsDcA { get; set; }
        public virtual ICollection<TrsVchrD> TrsVchrD { get; set; }
    }
}

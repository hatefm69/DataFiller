using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalOpr()
        {
            SalInvcD = new HashSet<SalInvcD>();
            SalInvcOpr = new HashSet<SalInvcOpr>();
            SalInvcSrvD = new HashSet<SalInvcSrvD>();
            SalInvcSrvOpr = new HashSet<SalInvcSrvOpr>();
            SalOprUser = new HashSet<SalOprUser>();
            SalPreInvcD = new HashSet<SalPreInvcD>();
            SalPreInvcOpr = new HashSet<SalPreInvcOpr>();
            SalPreInvcSrvD = new HashSet<SalPreInvcSrvD>();
            SalPreInvcSrvOpr = new HashSet<SalPreInvcSrvOpr>();
            SalRequestD = new HashSet<SalRequestD>();
            SalRequestOpr = new HashSet<SalRequestOpr>();
            SalRetInvcD = new HashSet<SalRetInvcD>();
            SalRetInvcOpr = new HashSet<SalRetInvcOpr>();
        }

        public int SalOprSi { get; set; }
        public string SalOprCu { get; set; }
        public string SalOprTp { get; set; }
        public double SalOprDefaultValue { get; set; }
        public byte SalOprValueTyp { get; set; }
        public short SalOprTyp { get; set; }
        public byte? SalOprSqnc { get; set; }
        public byte? SalOprSqncPrn { get; set; }
        public bool? SalOprActive { get; set; }
        public byte SalOprLckPrc { get; set; }
        public byte SalOprUse { get; set; }
        public bool? SalOprAutoInsert { get; set; }
        public string SalOprNature { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
        public bool? SalOprProject { get; set; }
        public bool? ShowInWeb { get; set; }

        public virtual CtbAccM AccMSiNavigation { get; set; }
        public virtual CtbAccT AccTSiNavigation { get; set; }
        public virtual ICollection<SalInvcD> SalInvcD { get; set; }
        public virtual ICollection<SalInvcOpr> SalInvcOpr { get; set; }
        public virtual ICollection<SalInvcSrvD> SalInvcSrvD { get; set; }
        public virtual ICollection<SalInvcSrvOpr> SalInvcSrvOpr { get; set; }
        public virtual ICollection<SalOprUser> SalOprUser { get; set; }
        public virtual ICollection<SalPreInvcD> SalPreInvcD { get; set; }
        public virtual ICollection<SalPreInvcOpr> SalPreInvcOpr { get; set; }
        public virtual ICollection<SalPreInvcSrvD> SalPreInvcSrvD { get; set; }
        public virtual ICollection<SalPreInvcSrvOpr> SalPreInvcSrvOpr { get; set; }
        public virtual ICollection<SalRequestD> SalRequestD { get; set; }
        public virtual ICollection<SalRequestOpr> SalRequestOpr { get; set; }
        public virtual ICollection<SalRetInvcD> SalRetInvcD { get; set; }
        public virtual ICollection<SalRetInvcOpr> SalRetInvcOpr { get; set; }
    }
}

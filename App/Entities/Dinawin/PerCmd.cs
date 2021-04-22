using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerCmd : DinawinBaseEntity, IMyEntityDinawin
    {
        public PerCmd()
        {
            PerCmdOpr = new HashSet<PerCmdOpr>();
        }

        public int PerCmdSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public string PerCmdCu { get; set; }
        public string PerCmdTp { get; set; }
        public string PerCmdBgnDs { get; set; }
        public string PerCmdEndDs { get; set; }
        public bool? PerCmdAct { get; set; }
        public string PerCmdCntrctNo { get; set; }
        public int PerCmdTypSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PerEmpTypSi { get; set; }
        public int? CtbOrgPstSi { get; set; }
        public int? CtbOrgDepSi { get; set; }
        public int? CtbOrgJobSi { get; set; }
        public int PerOprGrpSi { get; set; }
        public bool? PerCmdDelayed { get; set; }
        public string PerCmdDs { get; set; }
        public int? CtbProjectSi { get; set; }
        public int? SiAccT { get; set; }
        public int? PerjobTypSi { get; set; }
        public string PerCmdStmpCus { get; set; }
        public DateTime? PerCmdStmpCdt { get; set; }
        public string PerCmdStmpMus { get; set; }
        public DateTime? PerCmdStmpMdt { get; set; }
        public string PerCmdStmpTime { get; set; }
        public string PerCmdStmpTimeEdit { get; set; }

        public virtual CtbCost CtbCostSiNavigation { get; set; }
        public virtual CtbOrgDep CtbOrgDepSiNavigation { get; set; }
        public virtual CtbOrgJob CtbOrgJobSiNavigation { get; set; }
        public virtual CtbOrgPst CtbOrgPstSiNavigation { get; set; }
        public virtual PerCmdTyp PerCmdTypSiNavigation { get; set; }
        public virtual PerEmpTyp PerEmpTypSiNavigation { get; set; }
        public virtual PerOprGrp PerOprGrpSiNavigation { get; set; }
        public virtual PerPrsnl PerPrsnlSiNavigation { get; set; }
        public virtual ICollection<PerCmdOpr> PerCmdOpr { get; set; }
    }
}

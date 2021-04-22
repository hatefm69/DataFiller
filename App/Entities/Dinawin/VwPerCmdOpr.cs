using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerCmdOpr: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? PerCmdOprSi { get; set; }
        public string PerCmdOprCu { get; set; }
        public string PerCmdOprTp { get; set; }
        public int? PerCmdOprSeq { get; set; }
        public string PerCmdOprIf { get; set; }
        public string PerCmdOprCalc { get; set; }
        public bool? PerOprShowInCmd { get; set; }
        public string CtbOrgDepCu { get; set; }
        public string CtbOrgDepTp { get; set; }
        public string CtbOrgPstCu { get; set; }
        public string CtbOrgPstTp { get; set; }
        public string PerEmpTypCu { get; set; }
        public string PerEmpTypTp { get; set; }
        public string CtbCostCu { get; set; }
        public string CtbCostTp { get; set; }
        public string CtbOrgJobCu { get; set; }
        public string CtbOrgJobTp { get; set; }
        public string PerCmdTypCu { get; set; }
        public string PerCmdTypTp { get; set; }
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
        public int? CtbOrgPstSi { get; set; }
        public int? CtbOrgDepSi { get; set; }
        public int? CtbOrgJobSi { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public bool? PerPrsnlAct { get; set; }
        public int PerOprGrpSi { get; set; }
        public string PerPrsnlDAdrs { get; set; }
        public bool? PerCmdDelayed { get; set; }
        public string PerCmdDs { get; set; }
        public bool? PerOprIsmovagh { get; set; }
    }
}

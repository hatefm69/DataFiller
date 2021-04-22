using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerCmd: DinawinBaseEntity, IMyEntityDinawin
    {
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
        public int? PerEmpTypSi { get; set; }
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
        public int? CtbProjectSi { get; set; }
        public string PerOprGrpTp { get; set; }
        public string PerPrsnlDlocTp { get; set; }
        public int? PerPrsnlDlocSi { get; set; }
        public int? PerLocSi { get; set; }
        public string PerPrsnlIdNatCode { get; set; }
        public string PerPrsnlDBrtDte { get; set; }
        public string PerPrsnlDEmpDte { get; set; }
        public string PerPrsnlDEdu { get; set; }
        public string PerPrsnlDBnkName { get; set; }
        public string PerPrsnlDBnkBrnch { get; set; }
        public int? BankAccountNo { get; set; }
        public string PerjobTypCu { get; set; }
        public string PerPrsnlDWrkBgnDte { get; set; }
        public string PerPrsnlDWrkEndDte { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public int? PerTaxGrpSi { get; set; }
        public byte? PerInsrncGrpSi { get; set; }
        public DateTime? PerCmdStmpCdt { get; set; }
        public string PerCmdStmpMus { get; set; }
        public DateTime? PerCmdStmpMdt { get; set; }
        public string PerCmdStmpTime { get; set; }
        public string PerCmdStmpTimeEdit { get; set; }
        public string PerCmdStmpCus { get; set; }
    }
}

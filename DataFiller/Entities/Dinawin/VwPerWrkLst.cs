using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerWrkLst: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPrsnlSi { get; set; }
        public int PerPyrlPeriodSi { get; set; }
        public string PerWrkLstCu { get; set; }
        public string PerWrkLstTp { get; set; }
        public double PerWrkLstValue { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlFname { get; set; }
        public string PerPrsnlLname { get; set; }
        public string CtbOrgPstTp { get; set; }
        public int? CtbOrgDepSi { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PerOprGrpSi { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public int? PerEmpTypSi { get; set; }
        public int? PerLocSi { get; set; }
        public string PerPrsnlDWrkBgnDte { get; set; }
        public string PerPrsnlDWrkEndDte { get; set; }
        public string PerPrsnlDTypeCmd { get; set; }
        public string PerEmpTypTp { get; set; }
        public string PerTaxGrpCu { get; set; }
        public string PerTaxGrpTp { get; set; }
        public byte? PerInsrncGrpSi { get; set; }
        public string PerInsrncGrpTp { get; set; }
        public int? PerTaxGrpSi { get; set; }
    }
}

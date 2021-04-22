using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalDclrPrcD: DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalDclrPrcDSi { get; set; }
        public int? SalDclrPrcHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double SalDclrPrcDQty { get; set; }
        public decimal SalDclrPrcDUntPrc { get; set; }
        public bool SalDclrPrcDLckPrc { get; set; }
        public int? SalCustGrpSi { get; set; }
        public int? SalTypSi { get; set; }
        public string SalDclrPrcHDs { get; set; }
        public int? SalBrnchSi { get; set; }
        public decimal SalDclrPrcDUntPrcMin { get; set; }
        public decimal SalDclrPrcDUntPrcMax { get; set; }
        public int? InvUntSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public bool? SalDclrPrcDLckPrcUnt { get; set; }
        public int? CtbCurncySi { get; set; }
        public double? SalDclrPrcDUntPrcC { get; set; }
        public int? SalOprSi { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public int? SalOprSi2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public int? SalOprSi3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public bool? SalDclrPrcHStatus { get; set; }
        public int? SalDclrPrcHCu { get; set; }
    }
}

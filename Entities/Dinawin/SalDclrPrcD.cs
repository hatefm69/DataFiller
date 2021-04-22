using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDclrPrcD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalDclrPrcDSi { get; set; }
        public int? SalDclrPrcHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double SalDclrPrcDQty { get; set; }
        public decimal SalDclrPrcDUntPrc { get; set; }
        public double? SalDclrPrcDUntPrcC { get; set; }
        public decimal SalDclrPrcDUntPrcMin { get; set; }
        public decimal SalDclrPrcDUntPrcMax { get; set; }
        public bool SalDclrPrcDLckPrc { get; set; }
        public int? SalCustGrpSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? InvUntSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public int? CtbCurncySi { get; set; }
        public bool? SalDclrPrcDLckPrcUnt { get; set; }
        public int? SalOprSi { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public int? SalOprSi2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public int? SalOprSi3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }

        public virtual InvGdsTyp InvGds { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual InvUnt InvUntSiNavigation { get; set; }
        public virtual SalCustGrp SalCustGrpSiNavigation { get; set; }
        public virtual SalDclrPrcH SalDclrPrcHSiNavigation { get; set; }
    }
}

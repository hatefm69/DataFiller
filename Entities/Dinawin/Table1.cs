using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Table1 : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvGdsCu { get; set; }
        public int? SalDclrPrcDUntPrc { get; set; }
        public int? SalDclrPrcDUntPrcMin { get; set; }
        public int? SalDclrPrcDUntPrcMax { get; set; }
        public int? SalCustGrpSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalDclrPrcDUntPrcC { get; set; }
        public int? CtbCurncyTp { get; set; }
        public int? InvUntCu { get; set; }
        public int? InvGdsSi { get; set; }
        public int? InvUntSi { get; set; }
    }
}

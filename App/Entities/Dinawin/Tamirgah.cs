using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Tamirgah : DinawinBaseEntity, IMyEntityDinawin
    {
        public double? InvGdsCu { get; set; }
        public string SalDclrPrcDUntPrc { get; set; }
        public double? SalDclrPrcDUntPrcMin { get; set; }
        public double? SalDclrPrcDUntPrcMax { get; set; }
        public double? SalCustGrpSi { get; set; }
        public string SalTypSi { get; set; }
        public double? SalDclrPrcDUntPrcC { get; set; }
        public string CtbCurncyTp { get; set; }
        public double? InvUntCu { get; set; }
    }
}

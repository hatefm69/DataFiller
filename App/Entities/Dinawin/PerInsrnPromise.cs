using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerInsrnPromise : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerInsrnPromiseSi { get; set; }
        public string PerInsrnpromiseCu { get; set; }
        public string PerInsrnpromiseTp { get; set; }
        public int? PerInsrncGrpSi { get; set; }
    }
}

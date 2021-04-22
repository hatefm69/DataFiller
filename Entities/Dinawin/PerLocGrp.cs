using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerLocGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerLocGrpSi { get; set; }
        public int? PerLocSi { get; set; }
        public int? AccDocHSi { get; set; }
        public int? PerPyrlPeriodSi { get; set; }
    }
}

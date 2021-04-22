using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PersWorkTime : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PersWorkTimeSi { get; set; }
        public int? PersWorkTimeRate { get; set; }
        public int? PerPyrlPeriodSi { get; set; }
    }
}

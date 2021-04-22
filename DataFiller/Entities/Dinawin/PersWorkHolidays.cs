using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PersWorkHolidays : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PersWorkHolidaysSi { get; set; }
        public int? PersWorkHolidaysNumber { get; set; }
        public int? PerPyrlPeriodSi { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccBudgetPeriodLog : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccBudgetPeriodLogSi { get; set; }
        public int AccBudgetPeriodSi { get; set; }
        public double? AccBudgetPeriodPrcNew { get; set; }
        public double? AccBudgetPeriodPrcOld { get; set; }
        public double? AccBudgetPeriodChangePrc { get; set; }
        public int? AccBudgetPeriodLevelSi { get; set; }

        public virtual AccBudgetPeriod AccBudgetPeriodSiNavigation { get; set; }
    }
}

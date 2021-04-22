using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccBudget : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccBudget()
        {
            AccArqst = new HashSet<AccArqst>();
            AccBudgetLog = new HashSet<AccBudgetLog>();
        }

        public int AccBudgetSi { get; set; }
        public string AccBudgetCu { get; set; }
        public string AccBudgetTp { get; set; }
        public DateTime? AccBudgetFromDs { get; set; }
        public DateTime? AccBudgetToDs { get; set; }
        public int? AccBudgetTypSi { get; set; }
        public int? AccBudgetHSi { get; set; }
        public int? AccLkSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLpSi { get; set; }
        public int? AccLcSi { get; set; }
        public double? AccBudgetPrc { get; set; }
        public double? AccBudgetPrcCredit { get; set; }
        public double? AccBudgetPrcCost { get; set; }
        public int? SiFather { get; set; }
        public int? AccBudgetTypAcc { get; set; }
        public double? AccBudgetPrcRemain { get; set; }
        public bool? AccBudgetIsGroup { get; set; }
        public int? AccBudgetLevel { get; set; }

        public virtual AccBudgetH AccBudgetHSiNavigation { get; set; }
        public virtual AccBudgetTyp AccBudgetTypSiNavigation { get; set; }
        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccK AccLkSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual ICollection<AccArqst> AccArqst { get; set; }
        public virtual ICollection<AccBudgetLog> AccBudgetLog { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccBudgetH : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccBudgetH()
        {
            AccBudget = new HashSet<AccBudget>();
        }

        public int AccBudgetHSi { get; set; }
        public bool? AccBudgetHActive { get; set; }
        public DateTime? AccBudgetHFrm { get; set; }
        public DateTime? AccBudgetHTo { get; set; }
        public string AccBudgetHTx { get; set; }
        public int? AccBudgetHStatus { get; set; }

        public virtual ICollection<AccBudget> AccBudget { get; set; }
    }
}

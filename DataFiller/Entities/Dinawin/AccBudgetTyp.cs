using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccBudgetTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccBudgetTyp()
        {
            AccBudget = new HashSet<AccBudget>();
        }

        public int AccBudgetTypSi { get; set; }
        public string AccBudgetTypTp { get; set; }

        public virtual ICollection<AccBudget> AccBudget { get; set; }
    }
}

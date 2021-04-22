using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvCostQc : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvCostQc()
        {
            InvCostQcUser = new HashSet<InvCostQcUser>();
        }

        public int InvCostQcSi { get; set; }
        public string InvCostQcCu { get; set; }
        public string InvCostQcTp { get; set; }

        public virtual ICollection<InvCostQcUser> InvCostQcUser { get; set; }
    }
}

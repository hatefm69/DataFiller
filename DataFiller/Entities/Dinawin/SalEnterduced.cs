using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalEnterduced : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalEnterduced()
        {
            SalCust = new HashSet<SalCust>();
        }

        public int SalEnterducedSi { get; set; }
        public string SalEnterducedTp { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
    }
}

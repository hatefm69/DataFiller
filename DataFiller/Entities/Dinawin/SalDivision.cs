using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDivision : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalDivision()
        {
            SalCust = new HashSet<SalCust>();
        }

        public int SalDivisionSi { get; set; }
        public string SalDivisionTp { get; set; }

        public virtual ICollection<SalCust> SalCust { get; set; }
    }
}

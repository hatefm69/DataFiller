using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerTaxH : DinawinBaseEntity, IMyEntityDinawin
    {
        public PerTaxH()
        {
            PerTaxD = new HashSet<PerTaxD>();
        }

        public int PerTaxHSi { get; set; }
        public string PerTaxHDs { get; set; }
        public string PerTaxHTp { get; set; }
        public bool? PerTaxHAct { get; set; }

        public virtual ICollection<PerTaxD> PerTaxD { get; set; }
    }
}

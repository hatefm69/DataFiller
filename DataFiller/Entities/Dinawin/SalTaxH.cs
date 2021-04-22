using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalTaxH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalTaxH()
        {
            SalTaxD = new HashSet<SalTaxD>();
        }

        public int SalTaxHSi { get; set; }
        public string SalTaxHDs { get; set; }
        public string SalTaxHTp { get; set; }
        public bool? SalTaxHAct { get; set; }

        public virtual ICollection<SalTaxD> SalTaxD { get; set; }
    }
}

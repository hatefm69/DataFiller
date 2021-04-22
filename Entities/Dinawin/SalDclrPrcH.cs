using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDclrPrcH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalDclrPrcH()
        {
            SalDclrPrcD = new HashSet<SalDclrPrcD>();
        }

        public int SalDclrPrcHSi { get; set; }
        public int? SalDclrPrcHCu { get; set; }
        public string SalDclrPrcHDs { get; set; }
        public string SalDclrPrcHTp { get; set; }
        public int? SalBrnchSi { get; set; }
        public bool? SalDclrPrcHStatus { get; set; }

        public virtual SalBrnch SalBrnchSiNavigation { get; set; }
        public virtual ICollection<SalDclrPrcD> SalDclrPrcD { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCntrctSts : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalCntrctSts()
        {
            SalCntrct = new HashSet<SalCntrct>();
        }

        public byte SalCntrctStsSi { get; set; }
        public string SalCntrctStsTp { get; set; }

        public virtual ICollection<SalCntrct> SalCntrct { get; set; }
    }
}

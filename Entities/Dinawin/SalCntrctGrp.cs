using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCntrctGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalCntrctGrp()
        {
            SalCntrct = new HashSet<SalCntrct>();
        }

        public string SalCntrctGrpSi { get; set; }
        public string SalCntrctGrpTp { get; set; }

        public virtual ICollection<SalCntrct> SalCntrct { get; set; }
    }
}

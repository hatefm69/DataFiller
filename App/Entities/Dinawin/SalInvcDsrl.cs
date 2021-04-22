using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalInvcDsrl : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcHSi { get; set; }
        public int InvGdsSi { get; set; }
        public string SalInvcDsrlSrl { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual SalInvcH SalInvcHSiNavigation { get; set; }
    }
}

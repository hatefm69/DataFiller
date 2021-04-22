using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalBrnch : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalBrnch()
        {
            SalBrnchUser = new HashSet<SalBrnchUser>();
            SalCust = new HashSet<SalCust>();
            SalDclrPrcH = new HashSet<SalDclrPrcH>();
            SalInvcH = new HashSet<SalInvcH>();
            SalInvcSrvH = new HashSet<SalInvcSrvH>();
            SalPreInvcH = new HashSet<SalPreInvcH>();
            SalPreInvcSrvH = new HashSet<SalPreInvcSrvH>();
            SalRequestH = new HashSet<SalRequestH>();
            SalRetInvcH = new HashSet<SalRetInvcH>();
        }

        public int SalBrnchSi { get; set; }
        public string SalBrnchCu { get; set; }
        public string SalBrnchTp { get; set; }
        public int SalBrnchSiParent { get; set; }

        public virtual ICollection<SalBrnchUser> SalBrnchUser { get; set; }
        public virtual ICollection<SalCust> SalCust { get; set; }
        public virtual ICollection<SalDclrPrcH> SalDclrPrcH { get; set; }
        public virtual ICollection<SalInvcH> SalInvcH { get; set; }
        public virtual ICollection<SalInvcSrvH> SalInvcSrvH { get; set; }
        public virtual ICollection<SalPreInvcH> SalPreInvcH { get; set; }
        public virtual ICollection<SalPreInvcSrvH> SalPreInvcSrvH { get; set; }
        public virtual ICollection<SalRequestH> SalRequestH { get; set; }
        public virtual ICollection<SalRetInvcH> SalRetInvcH { get; set; }
    }
}

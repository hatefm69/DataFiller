using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDrvr : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalDrvr()
        {
            SalInvcH = new HashSet<SalInvcH>();
            SalInvcSrvH = new HashSet<SalInvcSrvH>();
            SalPreInvcH = new HashSet<SalPreInvcH>();
            SalPreInvcSrvH = new HashSet<SalPreInvcSrvH>();
            SalRequestH = new HashSet<SalRequestH>();
        }

        public int SalDrvrSi { get; set; }
        public string SalDrvrTp { get; set; }
        public string SalDrvrTel { get; set; }
        public string SalDrvrAdrs { get; set; }
        public byte[] SalDrvrPhoto { get; set; }
        public string SalDrvrCarNo { get; set; }
        public string SalDrvrCarType { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public string SalDrvrCu { get; set; }

        public virtual ICollection<SalInvcH> SalInvcH { get; set; }
        public virtual ICollection<SalInvcSrvH> SalInvcSrvH { get; set; }
        public virtual ICollection<SalPreInvcH> SalPreInvcH { get; set; }
        public virtual ICollection<SalPreInvcSrvH> SalPreInvcSrvH { get; set; }
        public virtual ICollection<SalRequestH> SalRequestH { get; set; }
    }
}

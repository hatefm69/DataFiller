using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalSrv : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalSrv()
        {
            SalInvcSrvD = new HashSet<SalInvcSrvD>();
            SalPreInvcSrvD = new HashSet<SalPreInvcSrvD>();
            SalSrvAcc = new HashSet<SalSrvAcc>();
        }

        public int SalSrvSi { get; set; }
        public string SalSrvCu { get; set; }
        public string SalSrvTp { get; set; }
        public int? SalSrvSiParent { get; set; }
        public string SalSrvUnt { get; set; }
        public int? SalSrvGrpSi { get; set; }
        public decimal? SalSrvStdPrc { get; set; }

        public virtual ICollection<SalInvcSrvD> SalInvcSrvD { get; set; }
        public virtual ICollection<SalPreInvcSrvD> SalPreInvcSrvD { get; set; }
        public virtual ICollection<SalSrvAcc> SalSrvAcc { get; set; }
    }
}

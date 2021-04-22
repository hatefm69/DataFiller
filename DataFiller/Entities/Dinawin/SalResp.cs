using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalResp : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalResp()
        {
            SalInvcH = new HashSet<SalInvcH>();
            SalInvcSrvH = new HashSet<SalInvcSrvH>();
            SalPreInvcH = new HashSet<SalPreInvcH>();
            SalPreInvcSrvH = new HashSet<SalPreInvcSrvH>();
            SalRequestH = new HashSet<SalRequestH>();
            SalRespUser = new HashSet<SalRespUser>();
        }

        public int SalRespSi { get; set; }
        public string SalRespTp { get; set; }
        public string SalRespTel { get; set; }
        public string SalRespAdrs { get; set; }
        public byte[] SalRespPhoto { get; set; }
        public string SalRespTpEn { get; set; }

        public virtual ICollection<SalInvcH> SalInvcH { get; set; }
        public virtual ICollection<SalInvcSrvH> SalInvcSrvH { get; set; }
        public virtual ICollection<SalPreInvcH> SalPreInvcH { get; set; }
        public virtual ICollection<SalPreInvcSrvH> SalPreInvcSrvH { get; set; }
        public virtual ICollection<SalRequestH> SalRequestH { get; set; }
        public virtual ICollection<SalRespUser> SalRespUser { get; set; }
    }
}

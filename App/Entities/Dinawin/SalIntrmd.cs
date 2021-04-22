using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalIntrmd : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalIntrmd()
        {
            InvGdsGrant = new HashSet<InvGdsGrant>();
            MemberShip = new HashSet<MemberShip>();
            SalCust = new HashSet<SalCust>();
            SalInvcH = new HashSet<SalInvcH>();
            SalInvcSrvH = new HashSet<SalInvcSrvH>();
            SalPreInvcH = new HashSet<SalPreInvcH>();
            SalPreInvcSrvH = new HashSet<SalPreInvcSrvH>();
            SalRequestH = new HashSet<SalRequestH>();
            SalRetInvcH = new HashSet<SalRetInvcH>();
        }

        public int SalIntrmdSi { get; set; }
        public string SalIntrmdCu { get; set; }
        public string SalIntrmdTp { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLmSi2 { get; set; }
        public byte? SalIntrmdValueTyp { get; set; }
        public decimal? SalIntrmdDefaultValue { get; set; }

        public virtual ICollection<InvGdsGrant> InvGdsGrant { get; set; }
        public virtual ICollection<MemberShip> MemberShip { get; set; }
        public virtual ICollection<SalCust> SalCust { get; set; }
        public virtual ICollection<SalInvcH> SalInvcH { get; set; }
        public virtual ICollection<SalInvcSrvH> SalInvcSrvH { get; set; }
        public virtual ICollection<SalPreInvcH> SalPreInvcH { get; set; }
        public virtual ICollection<SalPreInvcSrvH> SalPreInvcSrvH { get; set; }
        public virtual ICollection<SalRequestH> SalRequestH { get; set; }
        public virtual ICollection<SalRetInvcH> SalRetInvcH { get; set; }
    }
}

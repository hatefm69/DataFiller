using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvCntrDocH : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvCntrDocH()
        {
            InvCntrDocD = new HashSet<InvCntrDocD>();
        }

        public int InvCntrDocHSi { get; set; }
        public int? InvCntrDocHCu { get; set; }
        public string InvCntrDocHTp { get; set; }
        public string InvCntrDocHDs { get; set; }
        public short? InvCntrDocHRfrncTyp { get; set; }
        public int? InvInvtSi { get; set; }
        public string InvCntrDocHStmpCus { get; set; }
        public DateTime? InvCntrDocHStmpCdt { get; set; }
        public string InvCntrDocHStmpMus { get; set; }
        public DateTime? InvCntrDocHStmpMdt { get; set; }
        public int? InvTypSi { get; set; }
        public int? InvCntrDocHSts { get; set; }
        public int? PurVndrSi { get; set; }
        public int? InvControlGdsSi { get; set; }
        public int? InvGdsEssentialSi { get; set; }
        public bool? InvCntrDocHAcp1 { get; set; }
        public bool? InvCntrDocHAcp2 { get; set; }

        public virtual ICollection<InvCntrDocD> InvCntrDocD { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurInvcH : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurInvcH()
        {
            PurInvcD = new HashSet<PurInvcD>();
            PurOrdr = new HashSet<PurOrdr>();
        }

        public int PurInvcHSi { get; set; }
        public DateTime PurInvcHDt { get; set; }
        public int PurVndrSi { get; set; }
        public int PurRespSi { get; set; }
        public int? PurInvcHScu { get; set; }
        public DateTime? PurInvcHSdt { get; set; }
        public string PurInvcHTp { get; set; }
        public decimal PurInvcHPrcTotal { get; set; }
        public bool? PurInvcHAccDoc { get; set; }
        public string PurInvcHStmpCus { get; set; }
        public DateTime? PurInvcHStmpCdt { get; set; }
        public string PurInvcHStmpMus { get; set; }
        public DateTime? PurInvcHStmpMdt { get; set; }
        public int? InvInvtSi { get; set; }
        public int? InvDocHSi { get; set; }

        public virtual PurVndr PurVndrSiNavigation { get; set; }
        public virtual ICollection<PurInvcD> PurInvcD { get; set; }
        public virtual ICollection<PurOrdr> PurOrdr { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurPreInvcH : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurPreInvcH()
        {
            PurPreInvcD = new HashSet<PurPreInvcD>();
        }

        public int PurPreInvcHSi { get; set; }
        public int? PurOrdVndrSi { get; set; }
        public DateTime? PurPreVinvcHDt { get; set; }
        public DateTime? PurPreInvcHDtactive { get; set; }
        public string PurPreInvcHCu { get; set; }
        public string PurPreInvcHComment { get; set; }
        public int? PurOrderHSi { get; set; }
        public int? PurPreInvcHAttach { get; set; }
        public string PurPreInvcHFileName { get; set; }
        public byte[] PurPreInvcHFile { get; set; }
        public bool? PurPreInvcHHaveFile { get; set; }
        public bool? PurPreInvcHCancelled { get; set; }
        public bool? PurPreInvcHAccept { get; set; }
        public int? PurReqstHSi { get; set; }

        public virtual PurOrderH PurOrderHSiNavigation { get; set; }
        public virtual ICollection<PurPreInvcD> PurPreInvcD { get; set; }
    }
}

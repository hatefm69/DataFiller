using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurOrdr : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurOrdr()
        {
            PurEnqry = new HashSet<PurEnqry>();
            PurInvcD = new HashSet<PurInvcD>();
            PurRqstD = new HashSet<PurRqstD>();
        }

        public int PurOrdrSi { get; set; }
        public DateTime? PurOrdrDt { get; set; }
        public int InvGdsSi { get; set; }
        public int PurVndrSi { get; set; }
        public double PurOrdrQty { get; set; }
        public decimal PurOrdrUntPrc { get; set; }
        public decimal PurOrdrTotal { get; set; }
        public string PurOrdrTp { get; set; }
        public int PurEnqrySi { get; set; }
        public int? PurInvcHSi { get; set; }
        public byte? PurOrdHcnfrmSi { get; set; }
        public string PurOrdHcnfrmDesc { get; set; }
        public int? PurResPSi { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual PurInvcH PurInvcHSiNavigation { get; set; }
        public virtual PurVndr PurVndrSiNavigation { get; set; }
        public virtual ICollection<PurEnqry> PurEnqry { get; set; }
        public virtual ICollection<PurInvcD> PurInvcD { get; set; }
        public virtual ICollection<PurRqstD> PurRqstD { get; set; }
    }
}

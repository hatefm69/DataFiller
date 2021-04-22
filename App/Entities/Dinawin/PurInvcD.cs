using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurInvcD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurInvcHSi { get; set; }
        public int InvGdsSi { get; set; }
        public int? PurInvcDRow { get; set; }
        public double PurInvcDQty { get; set; }
        public decimal PurInvcDUntPrc { get; set; }
        public decimal PurInvcDIncPrc { get; set; }
        public decimal PurInvcDDecPrc { get; set; }
        public decimal PurInvcDTotal { get; set; }
        public string PurInvcDTp { get; set; }
        public int? PurOrdrSi { get; set; }
        public int? PurRqstHSi { get; set; }
        public DateTime? PurRqstHDt { get; set; }
        public int? InvDocHSi { get; set; }
        public DateTime? InvDocHDt { get; set; }

        public virtual InvDocH InvDocHSiNavigation { get; set; }
        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual PurInvcH PurInvcHSiNavigation { get; set; }
        public virtual PurOrdr PurOrdrSiNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PrdcTraceDinfo : DinawinBaseEntity, IMyEntityDinawin
    {
        public PrdcTraceDinfo()
        {
            PrdcTraceDmaterial = new HashSet<PrdcTraceDmaterial>();
            PrdcTraceDprocess = new HashSet<PrdcTraceDprocess>();
        }

        public int PrdcTraceDinfoSi { get; set; }
        public int? PrdcTraceHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int? PrdcBomSi { get; set; }
        public int? PrdcLineTitleSi { get; set; }
        public double? PrdcTraceDinfoQuantity { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
        public int? PrdcTraceDinfoInvDocType { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual PrdcBom PrdcBomSiNavigation { get; set; }
        public virtual PrdcLineTitle PrdcLineTitleSiNavigation { get; set; }
        public virtual PrdcTraceH PrdcTraceHSiNavigation { get; set; }
        public virtual ICollection<PrdcTraceDmaterial> PrdcTraceDmaterial { get; set; }
        public virtual ICollection<PrdcTraceDprocess> PrdcTraceDprocess { get; set; }
    }
}

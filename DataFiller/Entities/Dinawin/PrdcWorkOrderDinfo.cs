using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PrdcWorkOrderDinfo : DinawinBaseEntity, IMyEntityDinawin
    {
        public PrdcWorkOrderDinfo()
        {
            PrdcWorkOrderDmaterial = new HashSet<PrdcWorkOrderDmaterial>();
            PrdcWorkOrderDprocess = new HashSet<PrdcWorkOrderDprocess>();
        }

        public int PrdcWorkOrderDinfoSi { get; set; }
        public int? PrdcWorkOrderHSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int? PrdcBomSi { get; set; }
        public int? PrdcLineTitleSi { get; set; }
        public double? PrdcWorkOrderDinfoQuantity { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual PrdcBom PrdcBomSiNavigation { get; set; }
        public virtual PrdcLineTitle PrdcLineTitleSiNavigation { get; set; }
        public virtual PrdcWorkOrderH PrdcWorkOrderHSiNavigation { get; set; }
        public virtual ICollection<PrdcWorkOrderDmaterial> PrdcWorkOrderDmaterial { get; set; }
        public virtual ICollection<PrdcWorkOrderDprocess> PrdcWorkOrderDprocess { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PrdcLineTitle : DinawinBaseEntity, IMyEntityDinawin
    {
        public PrdcLineTitle()
        {
            PrdcLine = new HashSet<PrdcLine>();
            PrdcTraceDinfo = new HashSet<PrdcTraceDinfo>();
            PrdcWorkOrderDinfo = new HashSet<PrdcWorkOrderDinfo>();
        }

        public int PrdcLineTitleSi { get; set; }
        public int? PrdcLineTitleCu { get; set; }
        public string PrdcLineTitleTp { get; set; }
        public int? PrdcBomSi { get; set; }

        public virtual PrdcBom PrdcBomSiNavigation { get; set; }
        public virtual ICollection<PrdcLine> PrdcLine { get; set; }
        public virtual ICollection<PrdcTraceDinfo> PrdcTraceDinfo { get; set; }
        public virtual ICollection<PrdcWorkOrderDinfo> PrdcWorkOrderDinfo { get; set; }
    }
}

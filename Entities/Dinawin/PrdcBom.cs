using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PrdcBom : DinawinBaseEntity, IMyEntityDinawin
    {
        public PrdcBom()
        {
            PrdcBomd = new HashSet<PrdcBomd>();
            PrdcLineTitle = new HashSet<PrdcLineTitle>();
            PrdcTraceDinfo = new HashSet<PrdcTraceDinfo>();
            PrdcWorkOrderDinfo = new HashSet<PrdcWorkOrderDinfo>();
        }

        public int PrdcBomSi { get; set; }
        public int? InvGdsSi { get; set; }
        public string PrdcBomFormula { get; set; }
        public bool? PrdcBomIsAlternative { get; set; }
        public string PrdcBomDescription { get; set; }
        public bool? PrdcBomActive { get; set; }
        public double? PrdcBomQuantity { get; set; }
        public string PrdcBomDefineDate { get; set; }
        public byte[] PrdcBomFile { get; set; }
        public string PrdcBomFileName { get; set; }
        public bool? PrdcBomChangeInWorkOrder { get; set; }

        public virtual InvGds InvGdsSiNavigation { get; set; }
        public virtual ICollection<PrdcBomd> PrdcBomd { get; set; }
        public virtual ICollection<PrdcLineTitle> PrdcLineTitle { get; set; }
        public virtual ICollection<PrdcTraceDinfo> PrdcTraceDinfo { get; set; }
        public virtual ICollection<PrdcWorkOrderDinfo> PrdcWorkOrderDinfo { get; set; }
    }
}

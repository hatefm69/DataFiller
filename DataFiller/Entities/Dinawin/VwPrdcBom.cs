using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcBom: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PrdcBomSi { get; set; }
        public int? InvGdsSi { get; set; }
        public string PrdcBomFormula { get; set; }
        public bool? PrdcBomIsAlternative { get; set; }
        public string PrdcBomDescription { get; set; }
        public bool? PrdcBomActive { get; set; }
        public double? PrdcBomQuantity { get; set; }
        public string PrdcBomDefineDate { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntCu { get; set; }
        public string InvUntTp { get; set; }
        public string InvGdsStatusTp { get; set; }
        public int? InvGdsStatusSi { get; set; }
        public bool? PrdcBomChangeInWorkOrder { get; set; }
    }
}

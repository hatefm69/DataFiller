using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcWorkOrderDmaterial: DinawinBaseEntity, IMyEntityDinawin
    {
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public int PrdcWorkOrderDmaterialSi { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PrdcWorkOrderDmaterialValue { get; set; }
        public int? PrdcBomdSi { get; set; }
    }
}

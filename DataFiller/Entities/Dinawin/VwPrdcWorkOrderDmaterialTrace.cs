using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcWorkOrderDmaterialTrace: DinawinBaseEntity, IMyEntityDinawin
    {
        public double? PrdcWorkOrderDmaterialValue { get; set; }
        public double? PrdcTraceDmaterialValue { get; set; }
        public int? InvGdsSi { get; set; }
        public int PrdcWorkOrderDmaterialSi { get; set; }
        public int? PrdcTraceDmaterialSi { get; set; }
        public int? PrdcTraceDinfoSi { get; set; }
        public double? QuantityForTrace { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
    }
}

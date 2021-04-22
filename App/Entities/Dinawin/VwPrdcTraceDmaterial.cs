using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcTraceDmaterial: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PrdcTraceDmaterialSi { get; set; }
        public int? PrdcTraceDinfoSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int? PrdcWorkOrderDmaterialSi { get; set; }
        public double? PrdcTraceDmaterialValue { get; set; }
        public int? PrdcTraceDmaterialInvDocType { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
    }
}

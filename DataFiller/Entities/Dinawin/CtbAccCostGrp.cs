using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAccCostGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiCostGrp { get; set; }
        public string Cuacc { get; set; }
        public string Tpacc { get; set; }
        public int? SiFather { get; set; }
    }
}

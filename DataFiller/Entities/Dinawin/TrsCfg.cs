using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsCfg : DinawinBaseEntity, IMyEntityDinawin
    {
        public bool? AcRsrc { get; set; }
        public bool? AcAsgn { get; set; }
        public bool? AcSts { get; set; }
        public bool AcAordr { get; set; }
        public bool? AcAcurncy { get; set; }
    }
}

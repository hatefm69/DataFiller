using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccDscr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccDscrSi { get; set; }
        public string AccDscrTp { get; set; }
        public string AccDscrTp2 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDscr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalDscrSi { get; set; }
        public string SalDscrTp { get; set; }
        public string SalDscrTp2 { get; set; }
    }
}

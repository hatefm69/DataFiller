using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDscr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDscrSi { get; set; }
        public string InvDscrTp { get; set; }
    }
}

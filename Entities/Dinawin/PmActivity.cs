using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmActivity : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmActivityId { get; set; }
        public string PmActivityDesc { get; set; }
        public int PmServiceRefId { get; set; }
    }
}

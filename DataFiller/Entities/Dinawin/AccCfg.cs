using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccCfg : DinawinBaseEntity, IMyEntityDinawin
    {
        public bool AccCfgReplication { get; set; }
        public int? AccLocSi { get; set; }
        public int? AccLocSiMain { get; set; }
        public bool? UnReplicate { get; set; }
    }
}

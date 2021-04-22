using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvGdstyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public string InvGdsTypTp { get; set; }
        public int InvUntSi { get; set; }
        public string InvUntTp { get; set; }
        public string InvUntCu { get; set; }
        public int InvGdsSi { get; set; }
    }
}

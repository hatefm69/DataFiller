using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurGdsToVndr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurGdsToVndrSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int? PurVndrSi { get; set; }
    }
}

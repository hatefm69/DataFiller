using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsGrpUserToUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsGrpUserToUserSi { get; set; }
        public string UserRec { get; set; }
        public int? TrsGrpUserSi { get; set; }
    }
}

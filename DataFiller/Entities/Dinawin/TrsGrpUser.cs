using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsGrpUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsGrpUserSi { get; set; }
        public string TrsGrpUserCu { get; set; }
        public string TrsGrpUserTp { get; set; }
        public bool? TrsGrpUserManger { get; set; }
    }
}

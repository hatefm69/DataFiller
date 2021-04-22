using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccGrpUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccGrpUserSi { get; set; }
        public string AccGrpUserCu { get; set; }
        public string AccGrpUserTp { get; set; }
        public bool? AccGrpUserManger { get; set; }
    }
}

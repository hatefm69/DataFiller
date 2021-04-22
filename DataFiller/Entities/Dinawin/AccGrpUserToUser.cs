using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccGrpUserToUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccGrpUserToUserSi { get; set; }
        public string UserRec { get; set; }
        public int? AccGrpUserSi { get; set; }
    }
}

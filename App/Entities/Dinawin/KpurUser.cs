using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class KpurUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurUserSi { get; set; }
        public string PurUserCu { get; set; }
        public int? PurLvlDSi { get; set; }
        public int? CtbOrgDepSi { get; set; }
    }
}

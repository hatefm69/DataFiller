using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalGrpUserToUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalGrpUserToUserSi { get; set; }
        public string UserRec { get; set; }
        public int? SalGrpUserSi { get; set; }
        public bool? SalGrpUserToUserIsManager { get; set; }

        public virtual SalGrpUser SalGrpUserSiNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalGrpUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalGrpUser()
        {
            SalGrpUserToUser = new HashSet<SalGrpUserToUser>();
        }

        public int SalGrpUserSi { get; set; }
        public string SalGrpUserCu { get; set; }
        public string SalGrpUserTp { get; set; }
        public bool? SalGrpUserManger { get; set; }

        public virtual ICollection<SalGrpUserToUser> SalGrpUserToUser { get; set; }
    }
}

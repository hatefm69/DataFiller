using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDocUserSi { get; set; }
        public string InvDocUserTp { get; set; }
        public int? InvDocTypSi { get; set; }
    }
}

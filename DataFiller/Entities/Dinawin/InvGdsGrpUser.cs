using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvGdsGrpUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsGrpUserSi { get; set; }
        public string InvGdsGrpUserTp { get; set; }
        public int? InvGdsGrpSi { get; set; }
    }
}

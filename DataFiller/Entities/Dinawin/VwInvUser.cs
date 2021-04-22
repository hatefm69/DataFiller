using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public string InvUsrLgnName { get; set; }
        public int? InvInvtSi { get; set; }
        public bool? InvUsrAcsMny { get; set; }
        public bool? InvUsrAcsQty { get; set; }
        public string InvUsrTp { get; set; }
    }
}

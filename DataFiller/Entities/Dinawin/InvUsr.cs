using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvUsr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvUsrSi { get; set; }
        public string InvUsrLgnName { get; set; }
        public string InvUsrTp { get; set; }
        public bool? InvUsrAcsMny { get; set; }
        public bool? InvUsrAcsQty { get; set; }
        public bool? InvUsrAccount { get; set; }
        public bool? InvUsrAcsM { get; set; }
        public bool? InvUsrAcsT { get; set; }
        public bool? InvUsrAcsC { get; set; }
        public bool? InvUsrAcsP { get; set; }
        public int? InvUsrNumDay { get; set; }
    }
}

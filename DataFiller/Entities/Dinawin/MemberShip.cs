using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class MemberShip : DinawinBaseEntity, IMyEntityDinawin
    {
        public int MemberShipId { get; set; }
        public int SalIntrmdSi { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }

        public virtual SalIntrmd SalIntrmdSiNavigation { get; set; }
    }
}

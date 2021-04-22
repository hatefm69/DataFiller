using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalIntrmdUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalIntrmdUserSi { get; set; }
        public string UserRec { get; set; }
        public int SalIntrmdSi { get; set; }
    }
}

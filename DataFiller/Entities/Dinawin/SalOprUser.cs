using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalOprUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalOprUserSi { get; set; }
        public string UserRec { get; set; }
        public int? SalOprSi { get; set; }

        public virtual SalOpr SalOprSiNavigation { get; set; }
    }
}

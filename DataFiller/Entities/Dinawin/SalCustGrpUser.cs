using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCustGrpUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalCustGrpUserSi { get; set; }
        public string UserRec { get; set; }
        public int SalCustGrpSi { get; set; }
    }
}

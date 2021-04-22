using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalSrvGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalSrvGrpSi { get; set; }
        public string SalSrvGrpCu { get; set; }
        public string SalSrvGrpTp { get; set; }
        public int? SalSrvGrpSiParent { get; set; }
    }
}

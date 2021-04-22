using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalSrv : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalSrvSi { get; set; }
        public string SalSrvCu { get; set; }
        public string SalSrvTp { get; set; }
        public int? SalSrvSiParent { get; set; }
        public string SalSrvUnt { get; set; }
    }
}

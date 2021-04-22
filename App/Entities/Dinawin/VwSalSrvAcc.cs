using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalSrvAcc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? AccTSi { get; set; }
        public string AccTCu { get; set; }
        public string AccTTp { get; set; }
        public int? AccMSi { get; set; }
        public string AccMCu { get; set; }
        public string AccMTp { get; set; }
        public string SalSrvCu { get; set; }
        public string SalSrvTp { get; set; }
        public string SalSrvUnt { get; set; }
        public int SalSrvSi { get; set; }
        public string AccTTp2 { get; set; }
        public string AccMTp2 { get; set; }
    }
}

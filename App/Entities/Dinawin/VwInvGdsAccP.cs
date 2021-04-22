using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvGdsAccP : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsSi { get; set; }
        public int AccLpSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLpTp2 { get; set; }
        public string AccLtTp2 { get; set; }
        public string AccLmTp2 { get; set; }
    }
}

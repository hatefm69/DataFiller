using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvGdsAccC : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsSi { get; set; }
        public int AccLcSi { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLcTp2 { get; set; }
        public string AccLmTp2 { get; set; }
        public string AccLtTp2 { get; set; }
    }
}

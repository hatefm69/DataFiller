using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccLt : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccLtSi { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string AccLtTp2 { get; set; }
        public int SiFather { get; set; }
    }
}

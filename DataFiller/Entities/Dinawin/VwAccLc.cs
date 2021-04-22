using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccLc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccLcSi { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLcTp2 { get; set; }
        public int? SiFather { get; set; }
    }
}

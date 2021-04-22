using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccLmc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccLmSi { get; set; }
        public int AccLcSi { get; set; }
        public string AccLcCu { get; set; }
        public string AccLcTp { get; set; }
        public string AccLcTp2 { get; set; }
    }
}

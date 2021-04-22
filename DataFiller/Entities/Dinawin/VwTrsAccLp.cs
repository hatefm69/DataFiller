using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsAccLp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccLmSi { get; set; }
        public int AccLpSi { get; set; }
        public string AccLpCu { get; set; }
        public string AccLpTp { get; set; }
    }
}

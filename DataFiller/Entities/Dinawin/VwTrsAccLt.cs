using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsAccLt : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccLmSi { get; set; }
        public int AccLtSi { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsAccLm : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccLmSi { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
    }
}

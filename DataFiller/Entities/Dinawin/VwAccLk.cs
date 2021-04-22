using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccLk : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccLkSi { get; set; }
        public int AccLgSi { get; set; }
        public string AccLkCu { get; set; }
        public string AccLkTp { get; set; }
        public string AccLkTp2 { get; set; }
    }
}

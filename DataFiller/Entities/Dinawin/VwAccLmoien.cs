using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccLmoien : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccLmSi { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public int AccLkSi { get; set; }
        public string AccLkCu { get; set; }
        public string AccLkTp { get; set; }
        public bool AccLmCnctT { get; set; }
        public bool AccLmCnctC { get; set; }
        public bool AccLmCnctP { get; set; }
        public string AccLmTp2 { get; set; }
        public string AccLkTp2 { get; set; }
        public int Nature { get; set; }
    }
}

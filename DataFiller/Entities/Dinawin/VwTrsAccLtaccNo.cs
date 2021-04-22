using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsAccLtaccNo : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public string TrsAccLtaccNoAccountNo { get; set; }
        public string TrsAccLtaccNoBankName { get; set; }
        public int TrsAccLtaccNoSi { get; set; }
        public int AccLtSi { get; set; }
    }
}

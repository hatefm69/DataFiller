using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsAccLtaccNo : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsAccLtaccNoSi { get; set; }
        public int AccLtSi { get; set; }
        public string TrsAccLtaccNoAccountNo { get; set; }
        public string TrsAccLtaccNoBankName { get; set; }
    }
}

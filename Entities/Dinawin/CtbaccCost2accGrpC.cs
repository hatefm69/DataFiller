using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbaccCost2accGrpC : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiAccCost2AccGrpC { get; set; }
        public string SiCost { get; set; }
        public string SiCostGrp { get; set; }
    }
}

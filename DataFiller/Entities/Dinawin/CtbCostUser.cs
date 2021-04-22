using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbCostUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiCostUser { get; set; }
        public int? SiCost { get; set; }
        public string UserRec { get; set; }
    }
}

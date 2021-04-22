using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class BgtAssignAccK : DinawinBaseEntity, IMyEntityDinawin
    {
        public int BgtAssignAccKSi { get; set; }
        public int? SiAccK { get; set; }
        public decimal? BgtAssignAccKAmnt { get; set; }
        public DateTime? BgtAssignAccKDate { get; set; }
    }
}

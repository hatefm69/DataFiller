using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class KpurLvlD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurLvlDSi { get; set; }
        public string PurLvlDCu { get; set; }
        public int? KpurLvlHSi { get; set; }
    }
}

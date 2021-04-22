using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbProjectPrsnl : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiProjectPrsnl { get; set; }
        public int? SiProject { get; set; }
        public int? PerPrsnlSi { get; set; }
    }
}

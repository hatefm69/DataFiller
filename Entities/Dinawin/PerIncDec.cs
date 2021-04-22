using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerIncDec : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerIncDecSi { get; set; }
        public int PerPrsnlSi { get; set; }
        public string PerIncDecDs { get; set; }
        public string PerIncDecTp { get; set; }
        public decimal PerIncDecPrc { get; set; }

        public virtual PerPrsnl PerPrsnlSiNavigation { get; set; }
    }
}

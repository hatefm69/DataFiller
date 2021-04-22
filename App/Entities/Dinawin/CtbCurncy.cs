using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbCurncy : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbCurncy()
        {
            AccDdoc = new HashSet<AccDdoc>();
            TrsRsrc = new HashSet<TrsRsrc>();
        }

        public int CtbCurncySi { get; set; }
        public string CtbCurncyTp { get; set; }
        public string CtbCurncyFmt { get; set; }
        public bool? CtbCurncyDefault { get; set; }

        public virtual ICollection<AccDdoc> AccDdoc { get; set; }
        public virtual ICollection<TrsRsrc> TrsRsrc { get; set; }
    }
}

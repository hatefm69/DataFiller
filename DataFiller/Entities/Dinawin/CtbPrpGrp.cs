using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbPrpGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbPrpGrp()
        {
            CtbPrpVlu = new HashSet<CtbPrpVlu>();
        }

        public int CtbPrpGrpSi { get; set; }
        public string CtbPrpGrpTp { get; set; }

        public virtual ICollection<CtbPrpVlu> CtbPrpVlu { get; set; }
    }
}

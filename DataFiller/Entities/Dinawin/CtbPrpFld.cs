using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbPrpFld : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbPrpFld()
        {
            CtbPrpVlu = new HashSet<CtbPrpVlu>();
        }

        public int CtbPrpFldSi { get; set; }
        public int CtbPrpGrpSi { get; set; }
        public string CtbPrpFldCu { get; set; }
        public string CtbPrpFldTp { get; set; }
        public int? CtbPrpFldClr { get; set; }
        public int? CtbPrpFldSqnc { get; set; }

        public virtual ICollection<CtbPrpVlu> CtbPrpVlu { get; set; }
    }
}

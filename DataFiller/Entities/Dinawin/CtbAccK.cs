using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAccK : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbAccK()
        {
            AccBudget = new HashSet<AccBudget>();
            AccDdoc = new HashSet<AccDdoc>();
            CtbAccM = new HashSet<CtbAccM>();
        }

        public int SiAccK { get; set; }
        public int SiAccGrp { get; set; }
        public string CuAcc { get; set; }
        public string TpAcc { get; set; }
        public DateTime CreateRec { get; set; }
        public string LoginName { get; set; }
        public string TpAcc2 { get; set; }
        public int? CuAcc2 { get; set; }
        public int? SiFather { get; set; }

        public virtual CtbAccGrp SiAccGrpNavigation { get; set; }
        public virtual ICollection<AccBudget> AccBudget { get; set; }
        public virtual ICollection<AccDdoc> AccDdoc { get; set; }
        public virtual ICollection<CtbAccM> CtbAccM { get; set; }
    }
}

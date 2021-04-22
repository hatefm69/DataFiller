using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsAsgn : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsAsgn()
        {
            TrsDcA = new HashSet<TrsDcA>();
        }

        public int TrsAsgnSi { get; set; }
        public string TrsAsgnTp { get; set; }
        public string TrsAsgnGrpSi { get; set; }
        public bool? TrsAsgnAct { get; set; }
        public int AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public bool? TrsAsgnUp { get; set; }
        public bool? TrsAsgnUr { get; set; }
        public byte AccLtCnstr { get; set; }
        public byte AccLcCnstr { get; set; }
        public byte AccLpCnstr { get; set; }

        public virtual CtbCost AccLcSiNavigation { get; set; }
        public virtual CtbAccM AccLmSiNavigation { get; set; }
        public virtual CtbProject AccLpSiNavigation { get; set; }
        public virtual CtbAccT AccLtSiNavigation { get; set; }
        public virtual TrsAsgnGrp TrsAsgnGrpSiNavigation { get; set; }
        public virtual ICollection<TrsDcA> TrsDcA { get; set; }
    }
}

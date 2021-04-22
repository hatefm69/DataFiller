using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsAsgnGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public TrsAsgnGrp()
        {
            TrsAsgn = new HashSet<TrsAsgn>();
            TrsAsgnGrpUsr = new HashSet<TrsAsgnGrpUsr>();
        }

        public string TrsAsgnGrpSi { get; set; }
        public string TrsAsgnGrpTp { get; set; }

        public virtual ICollection<TrsAsgn> TrsAsgn { get; set; }
        public virtual ICollection<TrsAsgnGrpUsr> TrsAsgnGrpUsr { get; set; }
    }
}

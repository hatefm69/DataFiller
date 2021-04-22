using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurVndrGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurVndrGrp()
        {
            PurVndr = new HashSet<PurVndr>();
        }

        public int PurVndrGrpSi { get; set; }
        public string PurVndrGrpCu { get; set; }
        public string PurVndrGrpTp { get; set; }
        public int? PurVndrGrpSiParent { get; set; }

        public virtual ICollection<PurVndr> PurVndr { get; set; }
    }
}

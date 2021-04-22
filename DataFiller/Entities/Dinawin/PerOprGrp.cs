using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerOprGrp : DinawinBaseEntity, IMyEntityDinawin
    {
        public PerOprGrp()
        {
            PerCmd = new HashSet<PerCmd>();
            PerOpr = new HashSet<PerOpr>();
        }

        public int PerOprGrpSi { get; set; }
        public string PerOprGrpTp { get; set; }
        public string PerOprGrpCu { get; set; }

        public virtual ICollection<PerCmd> PerCmd { get; set; }
        public virtual ICollection<PerOpr> PerOpr { get; set; }
    }
}

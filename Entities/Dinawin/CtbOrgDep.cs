using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbOrgDep : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbOrgDep()
        {
            CtbOrgPst = new HashSet<CtbOrgPst>();
            PerCmd = new HashSet<PerCmd>();
        }

        public int CtbOrgDepSi { get; set; }
        public string CtbOrgDepCu { get; set; }
        public string CtbOrgDepTp { get; set; }
        public int CtbOrgDepSiParent { get; set; }
        public short? CtbOrgDepLvl { get; set; }

        public virtual ICollection<CtbOrgPst> CtbOrgPst { get; set; }
        public virtual ICollection<PerCmd> PerCmd { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerEmpTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public PerEmpTyp()
        {
            PerCmd = new HashSet<PerCmd>();
        }

        public int PerEmpTypSi { get; set; }
        public string PerEmpTypCu { get; set; }
        public string PerEmpTypTp { get; set; }

        public virtual ICollection<PerCmd> PerCmd { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerCmdTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public PerCmdTyp()
        {
            PerCmd = new HashSet<PerCmd>();
        }

        public int PerCmdTypSi { get; set; }
        public string PerCmdTypCu { get; set; }
        public string PerCmdTypTp { get; set; }
        public byte? PerCmdTypTyp { get; set; }

        public virtual ICollection<PerCmd> PerCmd { get; set; }
    }
}

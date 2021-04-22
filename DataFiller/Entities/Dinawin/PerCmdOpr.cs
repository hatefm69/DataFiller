using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerCmdOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerCmdOprSi { get; set; }
        public int PerCmdSi { get; set; }
        public string PerCmdOprCu { get; set; }
        public string PerCmdOprTp { get; set; }
        public int PerCmdOprSeq { get; set; }
        public string PerCmdOprIf { get; set; }
        public string PerCmdOprCalc { get; set; }
        public bool? PerCmdOprIsMovagh { get; set; }

        public virtual PerCmd PerCmdSiNavigation { get; set; }
    }
}

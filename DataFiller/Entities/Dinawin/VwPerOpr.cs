using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerOpr: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerOprSi { get; set; }
        public int PerOprGrpSi { get; set; }
        public string PerOprCu { get; set; }
        public string PerOprTp { get; set; }
        public int PerOprSeq { get; set; }
        public string PerOprIf { get; set; }
        public string PerOprCalc { get; set; }
        public bool PerOprView { get; set; }
        public bool PerOprReadOnly { get; set; }
        public byte PerOprDisplayType { get; set; }
        public string PerOprDisplayFormat { get; set; }
        public bool PerOprShowInCmd { get; set; }
        public bool PerOprShowInPyrl { get; set; }
        public int? AccLmSi { get; set; }
        public bool PerOprWthAccT { get; set; }
        public bool PerOprWthCtbCost { get; set; }
        public bool PerOprShowInWlst { get; set; }
        public int? AccLtSi { get; set; }
        public short PerOprAccNature { get; set; }
        public bool? PerOprIsmovagh { get; set; }
        public bool? PerOprWthCtbWrkLst { get; set; }
        public bool? PerOprWthCtbProject { get; set; }
        public bool? PerOprShowInFish { get; set; }
        public bool? PerOprNotShwSumFish { get; set; }
        public bool? PerOprIsReadFish { get; set; }
        public bool? PerOprLock { get; set; }
        public bool? PerOprWthCmdAccT { get; set; }
        public bool? PerOprShowprnCmd { get; set; }
        public int? CtbProjectSi { get; set; }
        public int? CtbCostSi { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntLockProcess : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntLockProcessSi { get; set; }
        public string CntLockProcessUserName { get; set; }
        public string CntLockProcessLevelTx { get; set; }
        public int? CntLockProcessLevelNo { get; set; }
        public bool? CntLockProcessEndLevel { get; set; }
    }
}

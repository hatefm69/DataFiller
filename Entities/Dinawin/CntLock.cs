using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntLock : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntLockSi { get; set; }
        public string CntLockDate { get; set; }
        public string CntLockUserName { get; set; }
        public int? CntContractSi { get; set; }
        public string CntLockComment { get; set; }
        public int? CntLockProcessSi { get; set; }
    }
}

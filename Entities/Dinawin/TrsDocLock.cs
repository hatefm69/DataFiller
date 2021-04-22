using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDocLock : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDocLockSi { get; set; }
        public DateTime TrsDocLockFr { get; set; }
        public DateTime TrsDocLockTo { get; set; }
        public string TrsDocLockTx { get; set; }
        public bool TrsDocLockActive { get; set; }
    }
}

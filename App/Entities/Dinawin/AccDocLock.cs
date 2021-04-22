using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccDocLock : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccDocLockSi { get; set; }
        public DateTime AccDocLockFr { get; set; }
        public DateTime AccDocLockTo { get; set; }
        public string AccDocLockTx { get; set; }
        public bool? AccDocLockActive { get; set; }
    }
}

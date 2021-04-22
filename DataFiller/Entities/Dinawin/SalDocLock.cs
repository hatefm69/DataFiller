using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDocLock : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalDocLockSi { get; set; }
        public DateTime SalDocLockFr { get; set; }
        public DateTime SalDocLockTo { get; set; }
        public string SalDocLockTx { get; set; }
        public bool SalDocLockActive { get; set; }
    }
}

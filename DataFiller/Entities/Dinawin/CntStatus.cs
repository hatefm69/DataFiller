using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntStatus : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntStatusSi { get; set; }
        public string CntStatusTx { get; set; }
    }
}

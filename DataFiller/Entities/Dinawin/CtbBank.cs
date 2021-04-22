using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbBank : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CtbBankSi { get; set; }
        public string CtbBankTp { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalFixAccount : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalFixAccountSi { get; set; }
        public int? SiAccM { get; set; }
        public int? SalFixAccountCu { get; set; }
        public string SalFixAccountTp { get; set; }
    }
}

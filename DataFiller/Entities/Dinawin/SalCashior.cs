using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCashior : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalCashiorSi { get; set; }
        public string SalCashiorCu { get; set; }
        public string SalCashiorTp { get; set; }
    }
}

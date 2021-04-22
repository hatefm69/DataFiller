using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalTypPrn : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalTypPrnSi { get; set; }
        public string SalTypPrnTp { get; set; }
    }
}

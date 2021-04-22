using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalTypSi { get; set; }
        public string SalTypCu { get; set; }
        public string SalTypTp { get; set; }
    }
}

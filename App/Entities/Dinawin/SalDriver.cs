using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDriver : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalDriverSi { get; set; }
        public string SalDriverTp { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalBrnchUser: DinawinBaseEntity, IMyEntityDinawin
    {
        public string SalBrnchCu { get; set; }
        public string SalBrnchTp { get; set; }
        public int SalBrnchSi { get; set; }
    }
}

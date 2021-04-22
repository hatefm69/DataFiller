using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerInterNational : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerInterNationalSi { get; set; }
        public string PerInterNationalCu { get; set; }
        public string PerInterNationalTp { get; set; }
    }
}

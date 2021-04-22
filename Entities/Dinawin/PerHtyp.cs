using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerHtyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerHtypSi { get; set; }
        public string PerHtypTp { get; set; }
    }
}

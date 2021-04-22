using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSysDataDicD : DinawinBaseEntity, IMyEntityDinawin
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}

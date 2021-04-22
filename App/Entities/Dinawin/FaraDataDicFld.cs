using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraDataDicFld : DinawinBaseEntity, IMyEntityDinawin
    {
        public string ObjectName { get; set; }
        public string Trns { get; set; }
    }
}

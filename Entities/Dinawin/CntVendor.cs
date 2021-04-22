using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntVendor : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntVendorSi { get; set; }
        public int? PurVndrSi { get; set; }
    }
}

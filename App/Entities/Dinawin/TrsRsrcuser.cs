using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsRsrcuser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsRsrcuserSi { get; set; }
        public int? TrsRsrcSi { get; set; }
        public string UserRec { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsAsgnuser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsAsgnuserSi { get; set; }
        public int? TrsAsgnSi { get; set; }
        public string UserRec { get; set; }
    }
}

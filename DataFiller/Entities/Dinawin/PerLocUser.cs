using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerLocUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerLocuserSi { get; set; }
        public int? PerLocSi { get; set; }
        public string UserRec { get; set; }
    }
}

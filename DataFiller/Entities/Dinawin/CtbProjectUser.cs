using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbProjectUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiProjectUser { get; set; }
        public int? SiProject { get; set; }
        public string UserRec { get; set; }
    }
}

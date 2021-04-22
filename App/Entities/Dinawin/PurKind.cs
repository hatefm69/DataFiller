using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurKind : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurKindSi { get; set; }
        public string PurKindCu { get; set; }
        public string PurKindTp { get; set; }
        public int? PurKindSiParent { get; set; }
    }
}

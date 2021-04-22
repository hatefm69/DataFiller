using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsDcCattach : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsDcCattachSi { get; set; }
        public string TrsDcCattachDs { get; set; }
        public string TrsDcCattachTp { get; set; }
        public string TrsDcCattachFileName { get; set; }
        public byte[] TrsDcCattachFile { get; set; }
        public int? TrsDcCSi { get; set; }
    }
}

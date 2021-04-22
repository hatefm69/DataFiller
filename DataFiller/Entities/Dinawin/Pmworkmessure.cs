using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Pmworkmessure : DinawinBaseEntity, IMyEntityDinawin
    {
        public int WorkDurMessureId { get; set; }
        public int? WorkDurMessureCode { get; set; }
        public string WorkDurMessureTitle { get; set; }
        public string WorkDurMessureTitleLatin { get; set; }
    }
}

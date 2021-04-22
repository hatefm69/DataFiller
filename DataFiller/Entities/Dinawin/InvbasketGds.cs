using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvbasketGds : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvbasketGdsSi { get; set; }
        public string InvbasketGdsCu { get; set; }
        public string InvbasketGdsTp { get; set; }
    }
}

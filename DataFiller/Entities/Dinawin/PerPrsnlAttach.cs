using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPrsnlAttach : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPrsnlAttachSi { get; set; }
        public string PerPrsnlAttachDs { get; set; }
        public string PerPrsnlAttachTp { get; set; }
        public string PerPrsnlAttachFileName { get; set; }
        public byte[] PerPrsnlAttachFile { get; set; }
        public int? PerPrsnlSi { get; set; }

        public virtual PerPrsnl PerPrsnlSiNavigation { get; set; }
    }
}

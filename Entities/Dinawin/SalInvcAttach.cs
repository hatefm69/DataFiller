using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalInvcAttach : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcAttachSi { get; set; }
        public string SalInvcAttachDs { get; set; }
        public string SalInvcAttachTp { get; set; }
        public string SalInvcAttachFileName { get; set; }
        public byte[] SalInvcAttachFile { get; set; }
        public int? SalInvchSi { get; set; }

        public virtual SalInvcH SalInvchSiNavigation { get; set; }
    }
}

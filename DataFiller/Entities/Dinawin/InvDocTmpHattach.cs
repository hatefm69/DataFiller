using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvDocTmpHattach : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDocTmpHattachSi { get; set; }
        public string InvDocTmpHattachDs { get; set; }
        public string InvDocTmpHattachTp { get; set; }
        public string InvDocTmpHattachFileName { get; set; }
        public byte[] InvDocTmpHattachFile { get; set; }
        public int? InvDocTmpHSi { get; set; }

        public virtual InvDocTmpH InvDocTmpHSiNavigation { get; set; }
    }
}

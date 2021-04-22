using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerWrkLstAttach : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerWrkLstAttachSi { get; set; }
        public string PerWrkLstAttachDs { get; set; }
        public string PerWrkLstAttachTp { get; set; }
        public string PerWrkLstAttachFileName { get; set; }
        public byte[] PerWrkLstAttachFile { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccDocHattacH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccDocHattachSi { get; set; }
        public string AccDocHattachDs { get; set; }
        public string AccDocHattachTp { get; set; }
        public string AccDocHattachFileName { get; set; }
        public byte[] AccDocHattachFile { get; set; }
        public int? SiHdoc { get; set; }
        public string AccDocHattachFileExtension { get; set; }

        public virtual AccHdoc SiHdocNavigation { get; set; }
    }
}

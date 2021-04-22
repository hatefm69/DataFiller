using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccAdvR: DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccAdvRSi { get; set; }
        public DateTime? AccAdvRDs { get; set; }
        public int SiDdoc { get; set; }
        public string AccAdvRTp { get; set; }
        public int SiAccT { get; set; }
        public bool AccAdvRCancle { get; set; }
        public int? SiHdoc { get; set; }
    }
}

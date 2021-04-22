using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbArshv : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CtbArshvSi { get; set; }
        public string CtbArshvTbl { get; set; }
        public int CtbArshvTblSi { get; set; }
        public string CtbArshvTp { get; set; }
        public string CtbArshvFileName { get; set; }
        public byte[] CtbArshvData { get; set; }
    }
}

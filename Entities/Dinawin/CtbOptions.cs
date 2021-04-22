using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbOptions : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiOpt { get; set; }
        public string CuOpt { get; set; }
        public string GrpOpt { get; set; }
        public string TpOpt { get; set; }
        public byte? Type { get; set; }
        public string OptValue { get; set; }
        public string Items { get; set; }
        public string UserGuide { get; set; }
        public string Description { get; set; }
        public string TpForm { get; set; }
        public int? Row { get; set; }
    }
}

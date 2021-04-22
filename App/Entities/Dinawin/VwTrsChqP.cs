using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsChqP: DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccLtSi { get; set; }
        public string AccLtTp { get; set; }
        public int TrsChqPSi { get; set; }
        public int TrsChqPBgnNo { get; set; }
        public int TrsChqPEndNo { get; set; }
        public int? Apages { get; set; }
        public int? Acount { get; set; }
        public double? AmaxNo { get; set; }
        public int? Arem { get; set; }
        public double? Agap { get; set; }
        public bool? EndCheck { get; set; }
    }
}

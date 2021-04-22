using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssMachineTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public AssMachineTyp()
        {
            AssReceiptH = new HashSet<AssReceiptH>();
        }

        public int AssMachineTypSi { get; set; }
        public int? AssMachineTypCu { get; set; }
        public string AssMachineTypTp { get; set; }
        public int? AssMachineTypKm { get; set; }
        public int? AssMachineTypGuranteDur { get; set; }
        public int? AssMachineTypFirstGuranteDur { get; set; }

        public virtual ICollection<AssReceiptH> AssReceiptH { get; set; }
    }
}

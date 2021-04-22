using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraBarcode : DinawinBaseEntity, IMyEntityDinawin
    {
        public int FaraBarcodeSi { get; set; }
        public int? PrcCount { get; set; }
        public int? QtyCount { get; set; }
        public int? GdsCount { get; set; }
        public int? BatchCount { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerSponserShipRelated : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerSponserShipRelatedSi { get; set; }
        public string PerSponserShipRelatedTp { get; set; }
    }
}

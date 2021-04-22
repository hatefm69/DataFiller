using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssetTemp2 : DinawinBaseEntity, IMyEntityDinawin
    {
        public double? Assetid { get; set; }
        public int Sicost { get; set; }
        public string TpCost { get; set; }
    }
}

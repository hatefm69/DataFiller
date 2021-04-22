using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssetTemp : DinawinBaseEntity, IMyEntityDinawin
    {
        public double? Assetid { get; set; }
        public int AstlctnId { get; set; }
    }
}

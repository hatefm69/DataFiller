using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstAssetDprc : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public DateTime AstAssetDprcDate { get; set; }
        public decimal AstAssetDprcPrice { get; set; }
        public int? AstVchrId { get; set; }

        public virtual AstAsset AstAsset { get; set; }
    }
}

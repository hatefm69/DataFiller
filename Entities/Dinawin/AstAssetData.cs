using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstAssetData : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public int AstDataHId { get; set; }
        public int AstDataDId { get; set; }
        public string AstAssetDataValue { get; set; }

        public virtual AstAsset AstAsset { get; set; }
        public virtual AstDataD AstData { get; set; }
    }
}

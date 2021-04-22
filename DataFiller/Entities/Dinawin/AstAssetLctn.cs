using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstAssetLctn : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public DateTime AstAssetLctnDate { get; set; }
        public int? AstLctnId { get; set; }
        public string AstAssetLctnTx { get; set; }
        public int? SiCost { get; set; }
        public int? PerPrsnlSi { get; set; }
        public int? PerPrsnlfromSi { get; set; }

        public virtual AstAsset AstAsset { get; set; }
        public virtual AstLctn AstLctn { get; set; }
        public virtual CtbCost SiCostNavigation { get; set; }
    }
}

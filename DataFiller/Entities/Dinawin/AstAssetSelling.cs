using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstAssetSelling : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public DateTime AstAssetSellingDate { get; set; }
        public decimal AstAssetSellingPrice { get; set; }
        public string AstAssetSellingTx { get; set; }
        public int AccMbankSi { get; set; }
        public int? AccTbankSi { get; set; }
        public int? AccMdeprSi { get; set; }
        public int? AccMastGrpSi { get; set; }
        public int AccMbenfSi { get; set; }
        public int? AccTbenfSi { get; set; }

        public virtual CtbAccM AccMastGrpSiNavigation { get; set; }
        public virtual CtbAccM AccMbankSiNavigation { get; set; }
        public virtual CtbAccM AccMbenfSiNavigation { get; set; }
        public virtual CtbAccM AccMdeprSiNavigation { get; set; }
        public virtual CtbAccT AccTbankSiNavigation { get; set; }
        public virtual AstAsset AstAsset { get; set; }
    }
}

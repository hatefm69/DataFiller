using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstAssetAjst : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public DateTime AstAssetAjstDate { get; set; }
        public decimal AstAssetAjstPrice { get; set; }
        public string AstAssetAjstTx { get; set; }
        public short? AstAssetAjstType { get; set; }
        public int? AstAssetAjstSi { get; set; }
        public string AstAssetAjstDocNo { get; set; }
    }
}

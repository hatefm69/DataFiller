using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAstAssetLctn : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public DateTime AstAssetLctnDate { get; set; }
        public int? AstLctnId { get; set; }
        public string AstAssetLctnTx { get; set; }
        public string AstLctnTx { get; set; }
        public int? SiCost { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public int? PerPrsnlSi { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public string PerPrsnlFname { get; set; }
        public string PerPrsnlLname { get; set; }
        public int? PerPrsnlAstSi { get; set; }
        public string PerPrsnlAstTp { get; set; }
        public string PerPrsnlAstCu { get; set; }
        public int? PerPrsnlfromSi { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAstLocationNew : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public string AstAssetTx { get; set; }
        public int? AstLctnId { get; set; }
        public string AstLctnTx { get; set; }
    }
}

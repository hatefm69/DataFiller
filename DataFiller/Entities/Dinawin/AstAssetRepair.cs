using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstAssetRepair : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstAssetId { get; set; }
        public DateTime AstAssetRepairDate { get; set; }
        public decimal AstAssetRepairPrice { get; set; }
        public string AstAssetRepairTx { get; set; }
    }
}

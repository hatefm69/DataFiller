using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstAssign : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AstAssignSi { get; set; }
        public string AstAssetId { get; set; }
        public byte AstAssignType { get; set; }
        public DateTime? AstAssignDate { get; set; }

        public virtual AstAsset AstAsset { get; set; }
    }
}

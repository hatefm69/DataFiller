using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstSum : DinawinBaseEntity, IMyEntityDinawin
    {
        public AstSum()
        {
            AstAsset = new HashSet<AstAsset>();
        }

        public string AstSumId { get; set; }
        public string AstSumTx { get; set; }

        public virtual ICollection<AstAsset> AstAsset { get; set; }
    }
}

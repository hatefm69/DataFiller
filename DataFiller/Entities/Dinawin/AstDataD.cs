using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstDataD : DinawinBaseEntity, IMyEntityDinawin
    {
        public AstDataD()
        {
            AstAssetData = new HashSet<AstAssetData>();
            AstDataDitem = new HashSet<AstDataDitem>();
        }

        public int AstDataHId { get; set; }
        public int AstDataDId { get; set; }
        public string AstDataDTx { get; set; }

        public virtual AstDataH AstDataH { get; set; }
        public virtual ICollection<AstAssetData> AstAssetData { get; set; }
        public virtual ICollection<AstDataDitem> AstDataDitem { get; set; }
    }
}

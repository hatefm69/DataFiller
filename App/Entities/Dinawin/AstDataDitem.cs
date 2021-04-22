using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstDataDitem : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AstDataHId { get; set; }
        public int AstDataDId { get; set; }
        public string AstDataDitemId { get; set; }

        public virtual AstDataD AstData { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstDataH : DinawinBaseEntity, IMyEntityDinawin
    {
        public AstDataH()
        {
            AstDataD = new HashSet<AstDataD>();
        }

        public int AstDataHId { get; set; }
        public string AstDataHTx { get; set; }

        public virtual ICollection<AstDataD> AstDataD { get; set; }
    }
}

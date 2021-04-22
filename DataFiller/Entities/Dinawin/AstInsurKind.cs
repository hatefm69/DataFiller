using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstInsurKind : DinawinBaseEntity, IMyEntityDinawin
    {
        public AstInsurKind()
        {
            AstInsurance = new HashSet<AstInsurance>();
        }

        public string AstInsurKindCu { get; set; }
        public string AstInsurKindTp { get; set; }

        public virtual ICollection<AstInsurance> AstInsurance { get; set; }
    }
}

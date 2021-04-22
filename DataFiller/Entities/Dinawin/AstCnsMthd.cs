using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstCnsMthd : DinawinBaseEntity, IMyEntityDinawin
    {
        public AstCnsMthd()
        {
            AstGrup = new HashSet<AstGrup>();
        }

        public byte AstCnsMthdId { get; set; }
        public string AstCnsMthdTx { get; set; }

        public virtual ICollection<AstGrup> AstGrup { get; set; }
    }
}

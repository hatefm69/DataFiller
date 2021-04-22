using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstVchrH : DinawinBaseEntity, IMyEntityDinawin
    {
        public AstVchrH()
        {
            AstVchrD = new HashSet<AstVchrD>();
        }

        public int AstVchrHId { get; set; }
        public DateTime? AstVchrHDate { get; set; }
        public bool? AstVchrHSent { get; set; }
        public int? AccDocHSi { get; set; }
        public string AstVchrHTx { get; set; }
        public byte? AstVchrHType { get; set; }

        public virtual ICollection<AstVchrD> AstVchrD { get; set; }
    }
}

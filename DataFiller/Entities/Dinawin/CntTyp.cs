using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public CntTyp()
        {
            CntContract = new HashSet<CntContract>();
        }

        public int CntTypSi { get; set; }
        public string CntTypTx { get; set; }

        public virtual ICollection<CntContract> CntContract { get; set; }
    }
}

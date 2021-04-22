using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntReferenceTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public CntReferenceTyp()
        {
            CntReference = new HashSet<CntReference>();
        }

        public int CntReferenceTypSi { get; set; }
        public string CntReferenceTypTx { get; set; }

        public virtual ICollection<CntReference> CntReference { get; set; }
    }
}

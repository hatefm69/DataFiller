using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntAttachTyp : DinawinBaseEntity, IMyEntityDinawin
    {
        public CntAttachTyp()
        {
            CntAttachment = new HashSet<CntAttachment>();
        }

        public int CntAttachTypSi { get; set; }
        public string CntAttachTypTx { get; set; }

        public virtual ICollection<CntAttachment> CntAttachment { get; set; }
    }
}

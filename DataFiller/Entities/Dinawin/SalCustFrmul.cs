using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCustFrmul : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalCustFrmulSi { get; set; }
        public int AccMSi { get; set; }
        public short SalCustFrmulOpr { get; set; }

        public virtual CtbAccM AccMSiNavigation { get; set; }
    }
}

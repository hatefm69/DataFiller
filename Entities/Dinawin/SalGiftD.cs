using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalGiftD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalGiftDSi { get; set; }
        public int SalGiftHSi { get; set; }
        public int InvGdsSi { get; set; }
        public decimal? InvGdsQty { get; set; }
        public decimal? InvGdsTotal { get; set; }
        public int? InvUntSi { get; set; }

        public virtual SalGiftH SalGiftHSiNavigation { get; set; }
    }
}

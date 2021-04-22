using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalinvcGift : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcGiftSi { get; set; }
        public int? SalInvcHSi { get; set; }
        public int? SalGiftInvGdsSi { get; set; }
        public decimal? SalInvcGiftValue { get; set; }
    }
}

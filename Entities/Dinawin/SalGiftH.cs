using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalGiftH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalGiftH()
        {
            SalGiftD = new HashSet<SalGiftD>();
        }

        public int SalGiftHSi { get; set; }
        public int InvGdsSi { get; set; }
        public decimal? InvGdsQty { get; set; }
        public decimal? InvGdsTotal { get; set; }
        public byte? SalGiftAcsMny { get; set; }
        public bool? SalGiftActive { get; set; }

        public virtual ICollection<SalGiftD> SalGiftD { get; set; }
    }
}

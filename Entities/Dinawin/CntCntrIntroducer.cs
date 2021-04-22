using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntCntrIntroducer : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntCntrIntroducerSi { get; set; }
        public int CntContractSi { get; set; }
        public string CntCntrIntroducerName { get; set; }
        public decimal? CntCntrIntroducerPayment { get; set; }
    }
}

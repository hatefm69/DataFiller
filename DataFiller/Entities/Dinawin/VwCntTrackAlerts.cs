using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwCntTrackAlerts : DinawinBaseEntity, IMyEntityDinawin
    {
        public string CntNo { get; set; }
        public string CntSubject { get; set; }
        public string AlertIndex { get; set; }
        public string AlertTx { get; set; }
        public int? CntContractSi { get; set; }
        public string CntContractDate { get; set; }
    }
}

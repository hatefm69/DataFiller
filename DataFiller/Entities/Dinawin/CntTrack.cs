using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntTrack : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntTrackSi { get; set; }
        public int CntContractSi { get; set; }
        public string CntTrackDate { get; set; }
        public string CntTrackTx { get; set; }
        public string CntTrackComment { get; set; }

        public virtual CntContract CntContractSiNavigation { get; set; }
    }
}

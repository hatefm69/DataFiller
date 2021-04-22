using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssReceptionD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssReceptionDSi { get; set; }
        public int AssReceptionSi { get; set; }
        public string AssMachineSerial { get; set; }

        public virtual AssReception AssReceptionSiNavigation { get; set; }
    }
}

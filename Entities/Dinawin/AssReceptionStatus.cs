using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssReceptionStatus : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssReceptionStatusSi { get; set; }
        public string AssReceptionStatusTp { get; set; }
    }
}

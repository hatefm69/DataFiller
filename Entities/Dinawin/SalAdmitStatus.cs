using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalAdmitStatus : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalAdmitStatusSi { get; set; }
        public string SalAdmitStatusTp { get; set; }
    }
}

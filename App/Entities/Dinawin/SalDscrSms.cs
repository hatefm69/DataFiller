using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalDscrSms : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalDscrSmsSi { get; set; }
        public string SalDscrSmsTp { get; set; }
        public string SalDscrSmsTp2 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntCustStatus : DinawinBaseEntity, IMyEntityDinawin
    {
        public string CntCustStatusCu { get; set; }
        public string CntCustStatusTp { get; set; }
    }
}

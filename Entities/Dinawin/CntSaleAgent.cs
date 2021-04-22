using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntSaleAgent : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntSaleAgentSi { get; set; }
        public string CntSaleAgentCu { get; set; }
        public string CntSaleAgentTp { get; set; }
    }
}

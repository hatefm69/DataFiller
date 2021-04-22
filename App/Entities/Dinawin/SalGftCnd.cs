using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalGftCnd : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalGftCndSi { get; set; }
        public string SalGftCndDsFrm { get; set; }
        public string SalGftCndDsTo { get; set; }
        public string SalGftCndQty { get; set; }
        public string SalGftCndPrice { get; set; }
    }
}

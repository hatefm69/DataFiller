using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CustomerInputDinaVision : DinawinBaseEntity, IMyEntityDinawin
    {
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public int SalCustSi { get; set; }
    }
}

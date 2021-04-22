using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPaidType : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPaidTypeSi { get; set; }
        public string PerPaidTypeCu { get; set; }
        public string PerPaidTypeTp { get; set; }
    }
}

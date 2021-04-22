using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerInsurType : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerInsurTypeSi { get; set; }
        public string PerInsurTypeCu { get; set; }
        public string PerInsurTypeTp { get; set; }
    }
}

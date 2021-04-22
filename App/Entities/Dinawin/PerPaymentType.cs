using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPaymentType : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPaymentTypeSi { get; set; }
        public string PerPaymentTypeCu { get; set; }
        public string PerPaymentTypeTp { get; set; }
    }
}

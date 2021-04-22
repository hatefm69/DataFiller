using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class ShpCashier : DinawinBaseEntity, IMyEntityDinawin
    {
        public string ShpCashierId { get; set; }
        public string ShpCashierPassword { get; set; }
    }
}

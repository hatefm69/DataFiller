using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurBuySt : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurBuyStSi { get; set; }
        public string PurBuyStCu { get; set; }
    }
}

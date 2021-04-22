using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurBuyStUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurBuyStUserSi { get; set; }
        public int? PurBuyStSi { get; set; }
        public string UserRec { get; set; }
    }
}

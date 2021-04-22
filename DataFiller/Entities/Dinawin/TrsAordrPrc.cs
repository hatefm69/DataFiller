using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsAordrPrc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsAordrSi { get; set; }
        public int TrsCtypSi { get; set; }
        public decimal TrsAordrPrcPrc { get; set; }
    }
}

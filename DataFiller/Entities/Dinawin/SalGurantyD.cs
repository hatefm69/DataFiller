using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalGurantyD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalGurantyDSi { get; set; }
        public string Service { get; set; }
        public int SalGurantySi { get; set; }
        public DateTime? SalGurantyDDate { get; set; }
    }
}

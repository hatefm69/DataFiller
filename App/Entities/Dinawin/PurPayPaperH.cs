using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurPayPaperH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurPayPaperHSi { get; set; }
        public string PurPayPaperHCu { get; set; }
        public string PurPayPaperHDs { get; set; }
        public string PurPayPaperHDsc { get; set; }
        public string PurPayPaperHStmp { get; set; }
        public DateTime? PurPayPaperHStmpCdt { get; set; }
        public string PurPayPaperHCu2 { get; set; }
    }
}

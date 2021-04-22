using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntGds : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntGdsSi { get; set; }
        public int CntContractSi { get; set; }
        public int? InvGdsSi { get; set; }
        public int? InvUntSi { get; set; }
        public string CntGdsArbitaryTp { get; set; }
        public bool? CntGdsArbitaryFlag { get; set; }
        public double? CntGdsQuantity { get; set; }
        public decimal? CntGdsUnitPrice { get; set; }
        public string CntGdsComment { get; set; }
        public string CntGdsTx { get; set; }

        public virtual CntContract CntContractSiNavigation { get; set; }
    }
}

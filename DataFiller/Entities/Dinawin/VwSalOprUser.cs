using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalOprUser : DinawinBaseEntity, IMyEntityDinawin
    {
        public string SalOprCu { get; set; }
        public string SalOprTp { get; set; }
        public int SalOprSi { get; set; }
        public decimal SalOprDefaultValue { get; set; }
        public byte SalOprValueTyp { get; set; }
        public short SalOprTyp { get; set; }
        public byte? SalOprSqnc { get; set; }
        public byte? SalOprSqncPrn { get; set; }
        public bool SalOprActive { get; set; }
        public byte SalOprLckPrc { get; set; }
        public byte SalOprUse { get; set; }
        public bool SalOprAutoInsert { get; set; }
        public string SalOprNature { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
        public bool? SalOprProject { get; set; }
    }
}

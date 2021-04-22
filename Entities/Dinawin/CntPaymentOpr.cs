using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntPaymentOpr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntPaymentOprSi { get; set; }
        public string CntPaymentOprTx { get; set; }
        public decimal? CntPaymentOprDefaultValue { get; set; }
        public byte? CntPaymentOprValueTyp { get; set; }
        public short? CntPaymentOprTyp { get; set; }
    }
}

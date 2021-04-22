using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CntPayment : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CntPaymentSi { get; set; }
        public int CntContractSi { get; set; }
        public string CntPaymentTx { get; set; }
        public string CntPaymentDate { get; set; }
        public decimal? CntPaymentPrice { get; set; }
        public short? CntPaymentTyp { get; set; }
        public bool? CntPaymentOk { get; set; }
        public byte? CntPaymentMethod { get; set; }

        public virtual CntContract CntContractSiNavigation { get; set; }
    }
}

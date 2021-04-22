using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssReceiptD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssReceiptDSi { get; set; }
        public int? AssReceiptHSi { get; set; }
        public int? AssReceiptDserviceSi { get; set; }
        public int? AssReceiptDsubServiceSi { get; set; }
        public int? InvUntSi { get; set; }
        public byte? AssReceiptDserviceTyp { get; set; }
        public decimal? AssReceiptDOriginalPrice { get; set; }
        public decimal? AssReceiptDGurantePrice { get; set; }
        public decimal? AssReceiptDTotalPrice { get; set; }
        public double? AssReceiptDQty { get; set; }
        public string AssReceiptDDescription { get; set; }
        public bool? AssReceiptDGurante { get; set; }
        public int? AssReceiptDDocNo { get; set; }
        public bool? AssReceiptDDaghi { get; set; }

        public virtual AssReceiptH AssReceiptHSiNavigation { get; set; }
    }
}

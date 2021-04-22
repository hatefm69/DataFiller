using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTransVoucherD : DinawinBaseEntity, IMyEntityDinawin
    {
        public string TpAccM { get; set; }
        public string CuAccM { get; set; }
        public int? SiAccM { get; set; }
        public string TpAccT { get; set; }
        public string CuAccT { get; set; }
        public int? SiAccT { get; set; }
        public string TransVoucherDTx { get; set; }
        public decimal? TransVoucherDCredit { get; set; }
        public decimal? TransVoucherDDebit { get; set; }
        public int? TransVoucherDSi { get; set; }
        public DateTime? TransVoucherHDate { get; set; }
        public bool? TransVoucherHSent { get; set; }
        public string TransVoucherHTx { get; set; }
        public int? SiHdoc { get; set; }
        public int? CuDoc { get; set; }
        public string TpHdoc { get; set; }
        public int TransVoucherHSi { get; set; }
    }
}

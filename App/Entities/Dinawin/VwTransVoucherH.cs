using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTransVoucherH : DinawinBaseEntity, IMyEntityDinawin
    {
        public string TpHdoc { get; set; }
        public int? CuDoc { get; set; }
        public int? SiHdoc { get; set; }
        public string TransVoucherHTx { get; set; }
        public bool? TransVoucherHSent { get; set; }
        public DateTime? TransVoucherHDate { get; set; }
        public int TransVoucherHSi { get; set; }
    }
}

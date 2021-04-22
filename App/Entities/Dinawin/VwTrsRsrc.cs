using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTrsRsrc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TrsRsrcSi { get; set; }
        public string TrsRsrcTp { get; set; }
        public int TrsRsrcTypSi { get; set; }
        public string TrsRsrcTypTp { get; set; }
        public bool TrsRsrcAct { get; set; }
        public int? CtbCurncySi { get; set; }
        public string CtbCurncyTp { get; set; }
        public int AccLmSi { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public int? AccLtSi { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public decimal TrsRsrcMin { get; set; }
        public decimal TrsRsrcMax { get; set; }
        public decimal TrsRsrcMaxPay { get; set; }
        public string TrsRsrcBbrnch { get; set; }
        public string TrsRsrcBaccNo { get; set; }
        public string TrsRsrcBowner { get; set; }
        public int? AccLmSi2 { get; set; }
        public string AccLmCu2 { get; set; }
        public string AccLmTp2 { get; set; }
        public decimal TrsRsrcDebit { get; set; }
        public decimal TrsRsrcCredit { get; set; }
        public decimal TrsRsrcPrc { get; set; }
        public string CtbCurncyFmt { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public string TpAcc2 { get; set; }
        public string AccLmTp22 { get; set; }
        public string AccLtTp2 { get; set; }
        public string TpCost2 { get; set; }
        public string TpProject2 { get; set; }
        public string TrsRsrcAddres { get; set; }
        public string TrsRsrcIno { get; set; }
        public string TrsRsrcPerson { get; set; }
        public string TrsRsrcManger { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalRetInvDopr : DinawinBaseEntity, IMyEntityDinawin
    {
        public string SalOprCu { get; set; }
        public string SalOprTp { get; set; }
        public byte? SalOprValueTyp { get; set; }
        public int? SalOprAccTSi { get; set; }
        public int? SalOprAccMSi { get; set; }
        public string SalOprNature { get; set; }
        public decimal? SalretInvcDPrcDec { get; set; }
        public decimal? SalretInvcDPrcInc { get; set; }
        public int? SalRetInvcHSi { get; set; }
        public int? SalRetInvcHCu { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public int? SalOprSi { get; set; }
        public string SalRetInvcHTp { get; set; }
        public int? SalOprSi2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public decimal? SalretInvcDPrcDec2 { get; set; }
        public decimal? SalretInvcDPrcInc2 { get; set; }
        public string SalOprTp2 { get; set; }
        public byte? SalOprValueTyp2 { get; set; }
        public string SalOprNature2 { get; set; }
        public int? AccMSi2 { get; set; }
        public int? AccTSi2 { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public byte? SalOprValueTyp3 { get; set; }
        public int? AccMSi3 { get; set; }
        public int? AccTSi3 { get; set; }
        public string SalOprNature3 { get; set; }
        public decimal? SalretInvcDPrcDec3 { get; set; }
        public decimal? SalretInvcDPrcInc3 { get; set; }
        public short? SalOprTyp { get; set; }
        public short? SalOprTyp2 { get; set; }
    }
}

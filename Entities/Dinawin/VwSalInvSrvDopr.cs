using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalInvSrvDopr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SalInvcSrvHSi { get; set; }
        public int? SalInvcSrvHCu { get; set; }
        public string SalInvcSrvHTp { get; set; }
        public int? SalOprSi { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public decimal? SalInvcSrvDPrcDec { get; set; }
        public decimal? SalInvcSrvDPrcInc { get; set; }
        public string SalOprCu { get; set; }
        public string SalOprTp { get; set; }
        public byte SalOprValueTyp { get; set; }
        public string SalOprNature { get; set; }
        public int? SalOprAccMSi { get; set; }
        public int? SalOprAccTSi { get; set; }
        public string SalOprCu2 { get; set; }
        public string SalOprTp2 { get; set; }
        public int? SalOprSi2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public double? SalInvcSrvDPrcDec2 { get; set; }
        public double? SalInvcSrvDPrcInc2 { get; set; }
        public byte? SalOprValueTyp2 { get; set; }
        public string SalOprNature2 { get; set; }
        public int? AccMSi2 { get; set; }
        public int? AccTSi2 { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
    }
}

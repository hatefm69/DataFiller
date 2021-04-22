using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalInvDopr : DinawinBaseEntity, IMyEntityDinawin
    {
        public string SalOprCu { get; set; }
        public string SalOprTp { get; set; }
        public int? SalOprAccMSi { get; set; }
        public int? SalOprAccTSi { get; set; }
        public int? SalOprSi { get; set; }
        public byte? SalOprValueTyp { get; set; }
        public int? SalInvcHSi { get; set; }
        public int? SalInvcHCu { get; set; }
        public int? SalInvcHCu2 { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public string SalOprNature { get; set; }
        public double? SalInvcDPrcDec { get; set; }
        public double? SalInvcDPrcInc { get; set; }
        public string SalInvcHTp { get; set; }
        public int? SalCustSi { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
        public int? SalOprSi2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public byte? SalOprValueTyp2 { get; set; }
        public double? SalInvcDPrcDec2 { get; set; }
        public double? SalInvcDPrcInc2 { get; set; }
        public string SalOprNature2 { get; set; }
        public int? AccMSi2 { get; set; }
        public int? AccTSi2 { get; set; }
        public byte? SalOprValueTyp3 { get; set; }
        public string SalOprNature3 { get; set; }
        public int? AccMSi3 { get; set; }
        public int? AccTSi3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public double? SalInvcDPrcDec3 { get; set; }
        public double? SalInvcDPrcInc3 { get; set; }
        public bool? SalOprProject { get; set; }
        public bool? SalOprProject2 { get; set; }
        public bool? SalOprProject3 { get; set; }
        public int? SalInvcHGood { get; set; }
        public short? SalOprTyp { get; set; }
        public short? SalOprTyp2 { get; set; }
        public short? SalOprTyp3 { get; set; }
        public int? SalOprSi3 { get; set; }
    }
}

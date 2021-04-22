using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalInvcSrvD : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SalInvcSrvDSi { get; set; }
        public int? SalInvcSrvHSi { get; set; }
        public int? SalInvcSrvDRow { get; set; }
        public double? SalInvcSrvDQty { get; set; }
        public decimal? SalInvcSrvDUntPrc { get; set; }
        public decimal? SalInvcSrvDTotal { get; set; }
        public int? SalInvcSrvHCu { get; set; }
        public string SalInvcSrvHDs { get; set; }
        public string SalInvcSrvHTp { get; set; }
        public decimal? SalInvcSrvHPrcSumTotal { get; set; }
        public decimal? SalInvcSrvHPrcInc { get; set; }
        public decimal? SalInvcSrvHPrcDec { get; set; }
        public decimal? SalInvcSrvHPrcTotal { get; set; }
        public bool? SalInvcSrvHCancelled { get; set; }
        public int? SalCustSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public string SalIntrmdCu { get; set; }
        public string SalIntrmdTp { get; set; }
        public string SalTypCu { get; set; }
        public string SalTypTp { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public string SalBrnchCu { get; set; }
        public string SalBrnchTp { get; set; }
        public string SalInvcSrvDTp { get; set; }
        public bool? SalInvcSrvHAccDoc { get; set; }
        public int? SalSrvSi { get; set; }
        public string SalSrvCu { get; set; }
        public string SalSrvTp { get; set; }
        public int? SalSrvAccAccMSi { get; set; }
        public int? SalSrvAccAccTSi { get; set; }
        public string SalSrvUnt { get; set; }
        public string SalInvcSrvHStmpCus { get; set; }
        public DateTime? SalInvcSrvHStmpCdt { get; set; }
        public string SalInvcSrvHStmpMus { get; set; }
        public DateTime? SalInvcSrvHStmpMdt { get; set; }
        public decimal? SalInvcSrvDSumTotal { get; set; }
        public string SalOprTp3 { get; set; }
        public int? SalOprSi3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public double? SalInvcSrvDPrcDec3 { get; set; }
        public double? SalInvcSrvDPrcInc3 { get; set; }
        public double? SalInvcSrvDSumPrcInc { get; set; }
        public double? SalInvcSrvDSumPrcDec { get; set; }
        public double? SalInvcSrvDPrcInc2 { get; set; }
        public double? SalInvcSrvDPrcDec2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public string SalOprTp2 { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public int? SalOprSi { get; set; }
        public int? SalOprSi2 { get; set; }
        public decimal? SalInvcSrvDPrcDec { get; set; }
        public decimal? SalInvcSrvDPrcInc { get; set; }
        public string SalOprCu { get; set; }
        public string SaloprCu2 { get; set; }
        public DateTime? SalInvcSrvHDm { get; set; }
        public string BatchNumberD { get; set; }
        public string CtbAddrsZipcode { get; set; }
        public string CtbAddrsTel { get; set; }
        public string CtbAddrsPobox { get; set; }
        public string CtbAddrsAddrs { get; set; }
        public string CtbAddrsFax { get; set; }
        public string CtbAddrsEconamical { get; set; }
        public string CtbAddrsNatCode { get; set; }
        public int? SalCustGrpSi { get; set; }
        public short? SalCustCorporateTyp { get; set; }
        public int? SalCitySi { get; set; }
        public int? SalProvinceSi { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalInvcSrvH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalInvcSrvHSi { get; set; }
        public int? SalInvcSrvHCu { get; set; }
        public string SalInvcSrvHDs { get; set; }
        public string SalInvcSrvHTp { get; set; }
        public decimal SalInvcSrvHPrcSumTotal { get; set; }
        public decimal SalInvcSrvHPrcInc { get; set; }
        public decimal SalInvcSrvHPrcDec { get; set; }
        public decimal SalInvcSrvHPrcTotal { get; set; }
        public bool SalInvcSrvHCancelled { get; set; }
        public int SalCustSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public string SalIntrmdCu { get; set; }
        public string SalIntrmdTp { get; set; }
        public string SalTypCu { get; set; }
        public string SalTypTp { get; set; }
        public string SalCustTp { get; set; }
        public string SalBrnchCu { get; set; }
        public string SalBrnchTp { get; set; }
        public string CtbAddrsTel { get; set; }
        public string CtbAddrsZipcode { get; set; }
        public string CtbAddrsPobox { get; set; }
        public string CtbAddrsFax { get; set; }
        public string CtbAddrsAddrs { get; set; }
        public int? SalCustAccMSi { get; set; }
        public int? SalCustAccTSi { get; set; }
        public int? SalInvcSrvHCu2 { get; set; }
        public bool SalInvcSrvHAccDoc { get; set; }
        public bool SalInvcSrvHPrcRcvd { get; set; }
        public string SalInvcSrvHStmpCus { get; set; }
        public DateTime? SalInvcSrvHStmpCdt { get; set; }
        public string SalInvcSrvHStmpMus { get; set; }
        public DateTime? SalInvcSrvHStmpMdt { get; set; }
        public string SalCustCu { get; set; }
        public short? SalInvcSrvHRfrncTyp { get; set; }
        public string SalInvcSrvHReference { get; set; }
        public bool? SalInvcSrvHLock { get; set; }
        public string CtbAddrsEconamical { get; set; }
        public DateTime? SalInvcSrvHDm { get; set; }
        public string BatchNumberH { get; set; }
        public int? SalRespSi { get; set; }
        public int? SalDrvrSi { get; set; }
        public int? SalDlvrrSi { get; set; }
        public string CtbAddrsNatCode { get; set; }
        public int? SalCustGrpSi { get; set; }
        public short? SalCustCorporateTyp { get; set; }
        public int? SalCitySi { get; set; }
        public int? SalProvinceSi { get; set; }
    }
}

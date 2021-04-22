using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalPreInvcSrvH : DinawinBaseEntity, IMyEntityDinawin
    {
        public string SalDlvrrTp { get; set; }
        public int SalPreInvcSrvHSi { get; set; }
        public int? SalPreInvcSrvHCu { get; set; }
        public string SalPreInvcSrvHDs { get; set; }
        public string SalPreInvcSrvHTp { get; set; }
        public short SalPreInvcSrvHRfrncTyp { get; set; }
        public string SalPreInvcSrvHReference { get; set; }
        public string SalPreInvcSrvHDlvLoc { get; set; }
        public string SalPreInvcSrvHRcvMthd { get; set; }
        public decimal SalPreInvcSrvHPrcSumTotal { get; set; }
        public decimal SalPreInvcSrvHPrcInc { get; set; }
        public decimal SalPreInvcSrvHPrcDec { get; set; }
        public decimal SalPreInvcSrvHPrcTotal { get; set; }
        public byte SalPreInvcSrvHStatus { get; set; }
        public short? SalPreInvcSrvHExprTime { get; set; }
        public string SalPreInvcSrvHExprDate { get; set; }
        public int SalCustSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SalInvcSrvHSi { get; set; }
        public int? SalRespSi { get; set; }
        public int? SalDrvrSi { get; set; }
        public int? SalDlvrrSi { get; set; }
        public int? SalPrint1 { get; set; }
        public string SalPreInvcSrvHStmpCus { get; set; }
        public DateTime? SalPreInvcSrvHStmpCdt { get; set; }
        public string SalPreInvcSrvHStmpMus { get; set; }
        public DateTime? SalPreInvcSrvHStmpMdt { get; set; }
        public string SalDrvrTp { get; set; }
        public string SalRespTp { get; set; }
        public string SalIntrmdCu { get; set; }
        public string SalIntrmdTp { get; set; }
        public string SalTypCu { get; set; }
        public string SalTypTp { get; set; }
        public string SalBrnchCu { get; set; }
        public string SalBrnchTp { get; set; }
        public string SalCustTp { get; set; }
        public string CtbAddrsPobox { get; set; }
        public string CtbAddrsZipcode { get; set; }
        public string CtbAddrsTel { get; set; }
        public string CtbAddrsFax { get; set; }
        public string CtbAddrsAddrs { get; set; }
        public string SalCustCu { get; set; }
        public string CtbAddrsEconamical { get; set; }
        public DateTime? SalPreInvcSrvHDm { get; set; }
        public string BatchNumberH { get; set; }
        public bool? CtbAddrsDefault { get; set; }
    }
}

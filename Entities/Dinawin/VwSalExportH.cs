using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalExportH: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SalExportPrmHCu { get; set; }
        public string SalExportPrmHTp { get; set; }
        public string SalExportPrmHDs { get; set; }
        public int? SalPreInvcHSi { get; set; }
        public decimal? SalExportPrmHPrcSumTotal { get; set; }
        public decimal? SalExportPrmHPrcInc { get; set; }
        public decimal? SalExportPrmHPrcDec { get; set; }
        public decimal? SalExportPrmHPrcTotal { get; set; }
        public int? InvInvtSi { get; set; }
        public string SalTypCu { get; set; }
        public string SalTypTp { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public string SalBrnchCu { get; set; }
        public string SalBrnchTp { get; set; }
        public string SalExportPrmHStmpCus { get; set; }
        public DateTime? SalExportPrmHStmpCdt { get; set; }
        public string SalExportPrmHStmpMus { get; set; }
        public DateTime? SalExportPrmHStmpMdt { get; set; }
        public short? SalExportPrmHRfrncTyp { get; set; }
        public int? InvDocHAccMSi { get; set; }
        public int? SalPreInvcHCu { get; set; }
        public int SalExportPrmHSi { get; set; }
        public int? SalCustSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalTypSi { get; set; }
        public string CtbAddrsTel { get; set; }
        public string CtbAddrsEconamical { get; set; }
        public string CtbAddrsFax { get; set; }
        public string CtbAddrsAddrs { get; set; }
        public string SalCustTp { get; set; }
        public string SalCustCu { get; set; }
        public decimal? SalExportPrmHPrcSumTotalC { get; set; }
        public int? SalExportPrmHStS { get; set; }
        public DateTime? SalExportPrmHDm { get; set; }
        public string BatchNumberH { get; set; }
        public string SalExportPrmHCu2 { get; set; }
        public int? SalDlvrrSi { get; set; }
        public int? SalDriverSi { get; set; }
        public string SalDriverTp { get; set; }
        public string CtbAddrsNatCode { get; set; }
        public string CtbAddrsBankName { get; set; }
        public string CtbAddrsEmail { get; set; }
        public string CtbAddrsModem { get; set; }
        public string CtbAddrsMobile { get; set; }
        public string CtbAddrsZipcode { get; set; }
        public string CtbAddrsPobox { get; set; }
        public string SalCustGrpCu { get; set; }
        public string SalCustGrpTp { get; set; }
        public bool? SalExportPrmHLock { get; set; }
        public int? SalIntrmdSi { get; set; }
        public string SalIntrmdCu { get; set; }
        public string SalIntrmdTp { get; set; }
        public int? SalCustGrpSi { get; set; }
        public int? InvDocHCu { get; set; }
        public int? SalInvcHCu { get; set; }
        public int? SalDrvrSi { get; set; }
        public int? SiAccM { get; set; }
        public int? SalExpInvcHGood { get; set; }
        public int? CtbAddrsSi { get; set; }
        public string CtbAddrsCtbAddrsTel { get; set; }
        public string CtbAddrsCtbAddrsMobile { get; set; }
        public string CtbAddrsCtbAddrsZipCode { get; set; }
        public string CtbAddrsCtbAddrsPoBox { get; set; }
        public string CtbAddrsCtbAddrsFax { get; set; }
        public string CtbAddrsCtbAddrsModem { get; set; }
        public string CtbAddrsCtbAddrsAddrs { get; set; }
        public string CtbAddrsCtbAddrsEmail { get; set; }
        public bool? CtbAddrsCtbAddrsDefault { get; set; }
        public string CtbAddrsCtbAddrsNatCode { get; set; }
        public string CtbAddrsCtbAddrsEconamical { get; set; }
        public string CtbAddrsCtbAddrsCity { get; set; }
        public string CtbAddrsCtbAddrsOstan { get; set; }
        public string CtbAddrsCtbAddrsShahrestan { get; set; }
        public int? CtbAddrsCtbAddrsNumber { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalExportD: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? SalExportPrmHCu { get; set; }
        public int SalExportPrmHSi { get; set; }
        public string SalExportPrmHDs { get; set; }
        public decimal? SalExportPrmHPrcSumTotal { get; set; }
        public decimal? SalExportPrmHPrcInc { get; set; }
        public decimal? SalExportPrmHPrcDec { get; set; }
        public decimal? SalExportPrmHPrcTotal { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public double? SalExportPrmDQty { get; set; }
        public string InvUntCu { get; set; }
        public string InvUntTp { get; set; }
        public decimal? SalExportPrmDTotal { get; set; }
        public decimal? SalExportPrmDUntPrc { get; set; }
        public double? SalExportPrmDPrcInc { get; set; }
        public double? SalExportPrmDPrcDec { get; set; }
        public int? SalOprSi { get; set; }
        public string SalOprTp { get; set; }
        public double? SalOprDefaultValue { get; set; }
        public decimal? SalExportPrmHPrcSumTotalC { get; set; }
        public string InvGdsGrpCu { get; set; }
        public string InvGdsGrpTp { get; set; }
        public int? SalPreInvcHSi { get; set; }
        public int? SalPreInvcHCu { get; set; }
        public int? InvGdsSi { get; set; }
        public int? InvDocHAccMSi { get; set; }
        public int? InvInvtSi { get; set; }
        public int? SalExportPrmHStS { get; set; }
        public int? InvUntSi { get; set; }
        public int? SalExportPrmHSi2 { get; set; }
        public string InvGdsTechNo { get; set; }
        public double? SalExportPrmDPrcInc3 { get; set; }
        public double? SalExportPrmDPrcDec3 { get; set; }
        public double? SalOprDefaultValue3 { get; set; }
        public string SalOprTp3 { get; set; }
        public string SalExportPrmDTp { get; set; }
        public decimal? SalExportPrmDSumPrcDec { get; set; }
        public decimal? SalExportPrmDSumPrcInc { get; set; }
        public double? SalExportPrmDPrcInc2 { get; set; }
        public double? SalExportPrmDPrcDec2 { get; set; }
        public double? SalOprDefaultValue2 { get; set; }
        public string SalOprTp2 { get; set; }
        public string SalCustCu { get; set; }
        public string SalCustTp { get; set; }
        public int? SalCustSi { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public decimal? SalExportPrmDSumTotal { get; set; }
        public double? SalExportPrmDQty2 { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SalDrvrSi { get; set; }
        public int? SalDlvrrSi { get; set; }
        public int? SalCustGrpSi { get; set; }
        public int? InvGdsGrpSi { get; set; }
        public string BatchNumberD { get; set; }
        public string BatchNumberH { get; set; }
        public string InvGdsToInvShelf { get; set; }
        public int? SalExportPrmDSi { get; set; }
        public int? CtbAddrsSi { get; set; }
        public string CtbAddrsPobox { get; set; }
        public string CtbAddrsZipcode { get; set; }
        public string CtbAddrsTel { get; set; }
        public string CtbAddrsMobile { get; set; }
        public string CtbAddrsFax { get; set; }
        public string CtbAddrsModem { get; set; }
        public string CtbAddrsAddrs { get; set; }
        public string CtbAddrsEmail { get; set; }
        public bool? CtbAddrsDefault { get; set; }
        public string CtbAddrsNatCode { get; set; }
        public string CtbAddrsEconamical { get; set; }
        public string CtbAddrsCity { get; set; }
        public string CtbAddrsOstan { get; set; }
        public string CtbAddrsShahrestan { get; set; }
        public int? CtbAddrsNumber { get; set; }
    }
}

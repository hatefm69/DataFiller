using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalExportPrmH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalExportPrmH()
        {
            SalExportPrmD = new HashSet<SalExportPrmD>();
        }

        public int SalExportPrmHSi { get; set; }
        public int? SalExportPrmHCu { get; set; }
        public string SalExportPrmHTp { get; set; }
        public string SalExportPrmHDs { get; set; }
        public int? SalPreInvcHSi { get; set; }
        public int? InvDocHAccMSi { get; set; }
        public short? SalExportPrmHRfrncTyp { get; set; }
        public decimal? SalExportPrmHPrcSumTotal { get; set; }
        public decimal? SalExportPrmHPrcInc { get; set; }
        public decimal? SalExportPrmHPrcDec { get; set; }
        public decimal? SalExportPrmHPrcTotal { get; set; }
        public int? InvInvtSi { get; set; }
        public int? SalCustSi { get; set; }
        public string SalExportPrmHStmpCus { get; set; }
        public DateTime? SalExportPrmHStmpCdt { get; set; }
        public string SalExportPrmHStmpMus { get; set; }
        public DateTime? SalExportPrmHStmpMdt { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalExportPrmHStS { get; set; }
        public string SalExportPrmHCu2 { get; set; }
        public DateTime? SalExportPrmHDm { get; set; }
        public decimal? SalExportPrmHPrcSumTotalC { get; set; }
        public int? SalExportPrmHSi2 { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? SalDrvrSi { get; set; }
        public string BatchNumberH { get; set; }
        public int? SalExpInvcHGood { get; set; }
        public string SaExpInvcHRcvMthd { get; set; }
        public string SalExpInvcHDlvLoc { get; set; }
        public int? SalDlvrrSi { get; set; }
        public string SalExportPrmHBarNo { get; set; }
        public string SalExportPrmHDrivername { get; set; }
        public string DescDriver { get; set; }
        public int? SalDriverSi { get; set; }
        public int? SiAccM { get; set; }
        public bool? SalExportPrmHLock { get; set; }
        public int? SalExportPrmHPrcSumQty { get; set; }
        public int? SalPreprint { get; set; }
        public int? CtbAddrsSi { get; set; }

        public virtual SalPreInvcH SalPreInvcHSiNavigation { get; set; }
        public virtual ICollection<SalExportPrmD> SalExportPrmD { get; set; }
    }
}

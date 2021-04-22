using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalRetInvcH : DinawinBaseEntity, IMyEntityDinawin
    {
        public SalRetInvcH()
        {
            SalRetInvcD = new HashSet<SalRetInvcD>();
            SalRetInvcDsrl = new HashSet<SalRetInvcDsrl>();
            SalRetInvcOpr = new HashSet<SalRetInvcOpr>();
        }

        public int SalRetInvcHSi { get; set; }
        public int? SalRetInvcHCu { get; set; }
        public string SalRetInvcHDs { get; set; }
        public string SalRetInvcHTp { get; set; }
        public short SalRetInvcHRfrncTyp { get; set; }
        public string SalRetInvcHReference { get; set; }
        public decimal SalRetInvcHPrcSumTotal { get; set; }
        public decimal? SalRetInvcHPrcSumTotalC { get; set; }
        public decimal SalRetInvcHPrcInc { get; set; }
        public decimal SalRetInvcHPrcDec { get; set; }
        public decimal SalRetInvcHPrcTotal { get; set; }
        public bool? SalRetInvcHAccDoc { get; set; }
        public int SalCustSi { get; set; }
        public int? SalBrnchSi { get; set; }
        public int? SalIntrmdSi { get; set; }
        public int? InvInvtSi { get; set; }
        public int? InvDocHAccMSi { get; set; }
        public bool? SalRetInvcHLock { get; set; }
        public bool? SalInvcHAccDoc { get; set; }
        public int? SalTypSi { get; set; }
        public int? SalInvcHSi { get; set; }
        public int? SalPrint { get; set; }
        public string SalRetInvcHStmpCus { get; set; }
        public DateTime? SalRetInvcHStmpCdt { get; set; }
        public string SalRetInvcHStmpMus { get; set; }
        public DateTime? SalRetInvcHStmpMdt { get; set; }
        public double? SalRetInvcHPrcGift { get; set; }
        public DateTime? SalRetInvcHDm { get; set; }
        public decimal? SalRetInvcHPrcInc2 { get; set; }
        public decimal? SalRetInvcHPrcDec2 { get; set; }
        public double? SalRetInvcHPrcSumQty { get; set; }
        public string BatchNumberH { get; set; }
        public double? SalRetInvcHIntrmdPrc { get; set; }
        public int? SalvarietySi { get; set; }
        public double? Remain { get; set; }
        public int? SalRetInvcHCu2 { get; set; }
        public int? SiAccM { get; set; }
        public int? SalRespSi { get; set; }
        public int? SiCost { get; set; }
        public bool? SalRetInvcHCancelled { get; set; }
        public int? InvDocHSi { get; set; }

        public virtual InvInvt InvInvtSiNavigation { get; set; }
        public virtual SalBrnch SalBrnchSiNavigation { get; set; }
        public virtual SalCust SalCustSiNavigation { get; set; }
        public virtual SalIntrmd SalIntrmdSiNavigation { get; set; }
        public virtual SalInvcH SalInvcHSiNavigation { get; set; }
        public virtual ICollection<SalRetInvcD> SalRetInvcD { get; set; }
        public virtual ICollection<SalRetInvcDsrl> SalRetInvcDsrl { get; set; }
        public virtual ICollection<SalRetInvcOpr> SalRetInvcOpr { get; set; }
    }
}

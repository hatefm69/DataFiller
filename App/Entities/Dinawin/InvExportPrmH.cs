using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class InvExportPrmH : DinawinBaseEntity, IMyEntityDinawin
    {
        public InvExportPrmH()
        {
            InvExportPrmD = new HashSet<InvExportPrmD>();
        }

        public int InvExportPrmHSi { get; set; }
        public int? InvExportPrmHCu { get; set; }
        public string InvExportPrmHTp { get; set; }
        public string InvExportPrmHDs { get; set; }
        public short? InvExportPrmHRfrncTyp { get; set; }
        public int? InvInvtSi { get; set; }
        public string InvExportPrmHStmpCus { get; set; }
        public DateTime? InvExportPrmHStmpCdt { get; set; }
        public string InvExportPrmHStmpMus { get; set; }
        public DateTime? InvExportPrmHStmpMdt { get; set; }
        public int? InvTypSi { get; set; }
        public int? InvExportPrmHSts { get; set; }
        public int? PurVndrSi { get; set; }
        public string InvExportPrmHNo { get; set; }
        public string InvExportPrmHDriver { get; set; }
        public string InvExportPrmHCar { get; set; }
        public string InvExportPrmHDest { get; set; }
        public string InvExportPrmHExtCus { get; set; }
        public string InvExportPrmHTahvil { get; set; }
        public string DescDriver { get; set; }
        public string BarNumber { get; set; }
        public string InvExportPrmHDlvBuy { get; set; }
        public string InvExportPrmHCarNo { get; set; }
        public int? PerPrsnlSi1 { get; set; }
        public int? PerPrsnlSi2 { get; set; }
        public int? InvExportPrmHGood { get; set; }
        public int? SalDriverSi { get; set; }
        public bool? InvExportPrmHLock { get; set; }

        public virtual ICollection<InvExportPrmD> InvExportPrmD { get; set; }
    }
}

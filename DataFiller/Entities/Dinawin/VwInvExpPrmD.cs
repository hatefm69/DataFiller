using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvExpPrmD : DinawinBaseEntity, IMyEntityDinawin
    {
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
        public double? InvExportPrmDQty { get; set; }
        public int? InvGdsSi { get; set; }
        public int? InvUntSi { get; set; }
        public int? InvGdsTypSi { get; set; }
        public string InvExportPrmDTp { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvGdsTechNo { get; set; }
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
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public string PerPrsnlCu2 { get; set; }
        public string PerPrsnlTp2 { get; set; }
        public int? InvExportPrmHGood { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
    }
}

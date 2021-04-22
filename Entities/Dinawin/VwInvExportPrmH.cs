using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvExportPrmH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvExportPrmHCu { get; set; }
        public string InvExportPrmHTp { get; set; }
        public int InvExportPrmHSi { get; set; }
        public string InvExportPrmHDs { get; set; }
        public short? InvExportPrmHRfrncTyp { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public int? InvInvtSi { get; set; }
        public string InvExportPrmHStmpCus { get; set; }
        public DateTime? InvExportPrmHStmpCdt { get; set; }
        public string InvExportPrmHStmpMus { get; set; }
        public DateTime? InvExportPrmHStmpMdt { get; set; }
        public int? InvExportPrmHSts { get; set; }
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
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public int? PurVndrSi { get; set; }
        public int? InvTypSi { get; set; }
        public string InvTypCu { get; set; }
        public string InvTypTp { get; set; }
    }
}

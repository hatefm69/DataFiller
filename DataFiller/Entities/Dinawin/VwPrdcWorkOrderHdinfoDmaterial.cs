using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcWorkOrderHdinfoDmaterial: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? PrdcWorkOrderHSi { get; set; }
        public string PrdcWorkOrderHCu { get; set; }
        public string PrdcWorkOrderHDate { get; set; }
        public int? PrdcWorkOrderTypeSi { get; set; }
        public short? PrdcWorkOrderHPriority { get; set; }
        public bool? PrdcWorkOrderHStatus { get; set; }
        public string PrdcWorkOrderHFromDate { get; set; }
        public string PrdcWorkOrderHToDate { get; set; }
        public string PrdcWorkOrderHDescription { get; set; }
        public bool? PrdcWorkOrderHLock { get; set; }
        public string PrdcWorkOrderHStatusName { get; set; }
        public string PrdcWorkOrderHPriorityName { get; set; }
        public int? PrdcWorkOrderDinfoSi { get; set; }
        public int PrdcWorkOrderDmaterialSi { get; set; }
        public double? PrdcWorkOrderDmaterialValue { get; set; }
        public int? InvGdsSiM { get; set; }
        public string InvGdsCuM { get; set; }
        public string InvGdsTpM { get; set; }
        public int? InvUntSiM { get; set; }
        public string InvUntCuM { get; set; }
        public string InvUntTpM { get; set; }
        public int? InvGdsStatusSiM { get; set; }
        public string InvGdsStatusTpM { get; set; }
        public int? InvGdsSiI { get; set; }
        public string InvGdsCuI { get; set; }
        public string InvGdsTpI { get; set; }
        public string PrdcBomFormula { get; set; }
        public double? PrdcBomQuantity { get; set; }
        public int? PrdcBomSi { get; set; }
        public int? PrdcLineTitleSi { get; set; }
        public int? PrdcLineTitleCu { get; set; }
        public string PrdcLineTitleTp { get; set; }
    }
}

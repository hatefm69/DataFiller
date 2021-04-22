using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcBomd: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PrdcBomdSi { get; set; }
        public int? PrdcBomSi { get; set; }
        public int? InvGdsSi { get; set; }
        public double? PrdcBomdValue { get; set; }
        public double? PrdcBomdScrapValue { get; set; }
        public short? PrdcBomdStatus { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvGdsStatusTp { get; set; }
        public int? InvGdsStatusSi { get; set; }
        public int? InvGdsSiMaster { get; set; }
        public double? PrdcBomQuantity { get; set; }
    }
}

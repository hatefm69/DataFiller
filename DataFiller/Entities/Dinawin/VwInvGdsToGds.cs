using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvGdsToGds : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? InvGdsSiM { get; set; }
        public int? InvGdsSiD { get; set; }
        public double? InvGdsToGdsQty { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public int? InvInvtSi { get; set; }
        public string InvGdsCuM { get; set; }
        public string InvGdsTpM { get; set; }
        public string InvGdsCuD { get; set; }
        public string InvGdsTpD { get; set; }
        public string InvGdsTechNoD { get; set; }
        public string InvGdsTechNoM { get; set; }
        public string InvGdsGrpCuM { get; set; }
        public string InvGdsGrpTpM { get; set; }
        public int? InvGdsGrpSiM { get; set; }
        public int? InvGdsGrpSiD { get; set; }
        public string InvGdsGrpCuD { get; set; }
        public string InvGdsGrpTpD { get; set; }
    }
}

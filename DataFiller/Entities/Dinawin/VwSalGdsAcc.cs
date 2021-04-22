using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSalGdsAcc : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public string AccMCu { get; set; }
        public string AccMTp { get; set; }
        public string AccTCu { get; set; }
        public string AccTTp { get; set; }
        public int? AccTSi { get; set; }
        public string InvGdsGrpCu { get; set; }
        public string InvGdsGrpTp { get; set; }
        public int InvGdsGrpSi { get; set; }
        public int? AccMSi { get; set; }
        public int InvUntSi { get; set; }
        public string AccMTp2 { get; set; }
        public string AccTTp2 { get; set; }
        public int? SiProject { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public int? SiCost { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvInvt : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvInvtSi { get; set; }
        public int InvInvtSiParent { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public string InvInvtAddress { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public string AccLmCu { get; set; }
        public string AccLmTp { get; set; }
        public string AccLtCu { get; set; }
        public string AccLtTp { get; set; }
        public short? InvInvtTypeSi { get; set; }
        public bool? InvInvtIsActive { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvDocAuto : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvInvtSiSource { get; set; }
        public int InvDocTypSiSource { get; set; }
        public int InvInvtSiDest { get; set; }
        public int InvDocTypSiDest { get; set; }
        public bool? InvDocAutoExpandBom { get; set; }
        public string InvInvtCuSource { get; set; }
        public string InvInvtTpSource { get; set; }
        public string InvDocTypTpSource { get; set; }
        public string InvInvtCuDest { get; set; }
        public string InvInvtTpDest { get; set; }
        public string InvDocTypTpDest { get; set; }
        public string InvDocTypTpSource2 { get; set; }
        public string InvDocTypTpDest2 { get; set; }
    }
}

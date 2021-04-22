using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwInvDocTmpH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvDocTmpHSi { get; set; }
        public int? InvDocTmpHCu { get; set; }
        public string InvDocTmpHDs { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public string InvDocTmpHTp { get; set; }
        public bool? InvDocTmpHSentDoc { get; set; }
        public int? InvInvtSi { get; set; }
        public string InvDocTmpHStmpTim { get; set; }
        public string InvDocTmpHStmpCus { get; set; }
        public string InvDocTmpHExpNo { get; set; }
        public int? PurVndrSi { get; set; }
        public string InvDocTmpHSts { get; set; }
        public int? InvRqstHSi { get; set; }
    }
}

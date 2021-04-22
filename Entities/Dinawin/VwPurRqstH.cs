using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurRqstH: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurRqstHSi { get; set; }
        public DateTime? PurRqstHDt { get; set; }
        public int? CtbCostSi { get; set; }
        public int? PurRqstCuseSi { get; set; }
        public int? InvInvtSi { get; set; }
        public DateTime? PurRqstHRdt { get; set; }
        public string InvInvtCu { get; set; }
        public string InvInvtTp { get; set; }
        public string CtbCostCu { get; set; }
        public string CtbCostTp { get; set; }
        public string PurRqstCuseTp { get; set; }
        public string PurRqstHTp { get; set; }
        public byte PurRqstHcnfrmSi { get; set; }
        public string PurRqstHCnfrmDesc { get; set; }
        public string PurRqstHcnfrmTp { get; set; }
    }
}

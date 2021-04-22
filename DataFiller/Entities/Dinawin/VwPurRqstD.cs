using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurRqstD: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurRqstHSi { get; set; }
        public int InvGdsSi { get; set; }
        public double PurRqstDRqty { get; set; }
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
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string InvUntTp { get; set; }
        public int? PurEnqrySi { get; set; }
        public int? PurOrdrSi { get; set; }
        public string InvDocHCu { get; set; }
        public int InvUntSi { get; set; }
    }
}

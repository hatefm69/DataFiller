using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwkpurRqstH: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurRqstHSi { get; set; }
        public string PurRqstHCu { get; set; }
        public string PurRqstHTp { get; set; }
        public DateTime? PurRqstHDt { get; set; }
        public string CuProject { get; set; }
        public string CuCost { get; set; }
        public string TpProject { get; set; }
        public string TpCost { get; set; }
        public string PerName { get; set; }
        public string CtbOrgDepTp { get; set; }
        public string InvInvtTp { get; set; }
        public string InvInvtCu { get; set; }
        public int InvInvtSi { get; set; }
        public int? CtbOrgDepSi { get; set; }
        public string UserName { get; set; }
        public string PurRqstHOfficial { get; set; }
        public int? PurRqstHPlace { get; set; }
        public string PurRqstHQryTp { get; set; }
        public int? PurRqstHQryNo { get; set; }
        public string PurQryCu { get; set; }
        public int? PurRqstLastUserLvl { get; set; }
        public byte? PurRqstHOffNext { get; set; }
    }
}

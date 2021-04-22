using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class KpurRqstH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PurRqstHSi { get; set; }
        public string PurRqstHCu { get; set; }
        public string PurRqstHTp { get; set; }
        public DateTime? PurRqstHDt { get; set; }
        public int? PurRqstHPlace { get; set; }
        public string PurRqstHOfficial { get; set; }
        public int? SiCost { get; set; }
        public int? PerPrsnlSi { get; set; }
        public int? SiProject { get; set; }
        public int? InvInvtSi { get; set; }
        public int? CtbOrgDepSi { get; set; }
        public string UserName { get; set; }
        public string PurRqstHQryTp { get; set; }
        public int? PurRqstHQryNo { get; set; }
        public int? PurRqstLastUserLvl { get; set; }
        public byte? PurRqstHOffNext { get; set; }
    }
}

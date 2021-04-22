using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPerPrsnl: DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPrsnlSi { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public string CtbOrgDepCu { get; set; }
        public string CtbOrgDepTp { get; set; }
        public string CtbOrgJobCu { get; set; }
        public string CtbOrgJobTp { get; set; }
        public string CtbOrgPstCu { get; set; }
        public string CtbOrgPstTp { get; set; }
        public bool PerPrsnlAct { get; set; }
    }
}

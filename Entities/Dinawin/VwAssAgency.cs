using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAssAgency : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? AssAgencyCu { get; set; }
        public string AssAgencyTp { get; set; }
        public string AssAgencyMng { get; set; }
        public string CtbAddrsTel { get; set; }
        public string CtbAddrsDesc { get; set; }
        public string CtbAddrsPobox { get; set; }
        public string CtbAddrsZipcode { get; set; }
        public string CtbAddrsMobile { get; set; }
        public string CtbAddrsFax { get; set; }
        public string CtbAddrsModem { get; set; }
        public string CtbAddrsAddrs { get; set; }
        public string CtbAddrsEmail { get; set; }
        public int AssAgencySi { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbAccDocDescFmt : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SiAccDocDescFmt { get; set; }
        public string Grp { get; set; }
        public string CuAccDocDescFmt { get; set; }
        public string TpAccDocDescFmt { get; set; }
        public string DescFmtFarDebit { get; set; }
        public string DescFmtFarCredit { get; set; }
        public string DescFmtLatDebit { get; set; }
        public string DescFmtLatCredit { get; set; }
    }
}

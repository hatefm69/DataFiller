using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraRs : DinawinBaseEntity, IMyEntityDinawin
    {
        public string FaraRsSi { get; set; }
        public string FaraRsSrchSql { get; set; }
        public string FaraRsCwhr { get; set; }
        public string FaraRsSwhr { get; set; }
        public string FaraRsRsltFmt { get; set; }
        public string FaraRsLstIdFld { get; set; }
        public string FaraRvSi { get; set; }
    }
}

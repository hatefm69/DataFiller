using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraRvEn : DinawinBaseEntity, IMyEntityDinawin
    {
        public string FaraRvSi { get; set; }
        public string FaraRvSql { get; set; }
        public string FaraRvFlds { get; set; }
        public string FaraRvCtrl { get; set; }
        public string FaraRvAftrWhr { get; set; }
    }
}

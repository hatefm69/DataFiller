using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraLog : DinawinBaseEntity, IMyEntityDinawin
    {
        public Guid LogSi { get; set; }
        public DateTime LogDt { get; set; }
        public string LogCtgry { get; set; }
        public string LogAction { get; set; }
        public string LogUser { get; set; }
        public string LogDesc { get; set; }
        public int? SiSystem { get; set; }
    }
}

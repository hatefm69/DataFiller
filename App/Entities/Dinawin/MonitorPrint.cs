using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class MonitorPrint : DinawinBaseEntity, IMyEntityDinawin
    {
        public int MonitorPrintId { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}

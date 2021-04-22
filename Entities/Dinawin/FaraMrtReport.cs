using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraMrtReport : DinawinBaseEntity, IMyEntityDinawin
    {
        public int FaraMrtReportId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public int? FaraMrtReportTypeId { get; set; }

        public virtual FaraMrtReportType FaraMrtReportType { get; set; }
    }
}

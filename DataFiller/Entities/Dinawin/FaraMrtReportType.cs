using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraMrtReportType : DinawinBaseEntity, IMyEntityDinawin
    {
        public FaraMrtReportType()
        {
            FaraMrtReport = new HashSet<FaraMrtReport>();
        }

        public int FaraMrtReportTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FaraMrtReport> FaraMrtReport { get; set; }
    }
}

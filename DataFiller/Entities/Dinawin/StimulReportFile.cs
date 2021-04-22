using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class StimulReportFile : DinawinBaseEntity, IMyEntityDinawin
    {
        public Guid StimulReportFileId { get; set; }
        public bool IsStandardReport { get; set; }
        public string FormName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsPublished { get; set; }
    }
}

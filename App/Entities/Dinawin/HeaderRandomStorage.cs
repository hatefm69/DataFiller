using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class HeaderRandomStorage : DinawinBaseEntity, IMyEntityDinawin
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string StartDateDs { get; set; }
        public DateTime? StartDateDm { get; set; }
        public int? Duration { get; set; }
    }
}

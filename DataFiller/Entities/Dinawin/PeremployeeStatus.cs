using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PeremployeeStatus : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PeremployeeStatusSi { get; set; }
        public string PeremployeeStatusCu { get; set; }
        public string PeremployeeStatusTp { get; set; }
    }
}

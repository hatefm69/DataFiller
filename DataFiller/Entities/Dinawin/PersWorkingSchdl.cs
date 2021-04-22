using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PersWorkingSchdl : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PersWorkingSchdlSi { get; set; }
        public string PersWorkingSchdlTp { get; set; }
        public int? PersWorkingSchdlShiftNo { get; set; }
    }
}

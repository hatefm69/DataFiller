using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class SalCancle : DinawinBaseEntity, IMyEntityDinawin
    {
        public int SalCancleSi { get; set; }
        public string SalCancleCu { get; set; }
        public string SalCancleTp { get; set; }
    }
}

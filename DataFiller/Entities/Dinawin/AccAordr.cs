using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccAordr : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AccAordrSi { get; set; }
        public DateTime AccAordrDt { get; set; }
        public int? AccArqstSi { get; set; }
        public string StmpCus { get; set; }
        public DateTime? StmpCdt { get; set; }
        public string StmpMus { get; set; }
        public DateTime? StmpMdt { get; set; }
    }
}

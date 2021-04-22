using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class DimDate : DinawinBaseEntity, IMyEntityDinawin
    {
        public int DateId { get; set; }
        public DateTime Gdate { get; set; }
        public string Pdate { get; set; }
        public int Pyear { get; set; }
        public int Pmonth { get; set; }
        public int Pday { get; set; }
        public string PmonthName { get; set; }
        public int PweekOfYear { get; set; }
        public string PdayName { get; set; }
        public string Pseason { get; set; }
    }
}

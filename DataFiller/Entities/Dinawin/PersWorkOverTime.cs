using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PersWorkOverTime : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PersWorkOverTimeSi { get; set; }
        public int? PersWorkOverTimeBeth { get; set; }
        public int? PersWorkOverTimePerson { get; set; }
        public int? PersWorkOverTimeWorkDay { get; set; }
        public int? PersWorkOverTimeValue129 { get; set; }
        public int? PersWorkOverTimeValue229 { get; set; }
        public int? PersWorkOverTimeValue130 { get; set; }
        public int? PersWorkOverTimeValue230 { get; set; }
        public int? PersWorkOverTimeValue131 { get; set; }
        public int? PersWorkOverTimeValue231 { get; set; }
        public int? CtbCostSi { get; set; }
    }
}

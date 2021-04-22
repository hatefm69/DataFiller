using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PersWorkList : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerPrsnlSi { get; set; }
        public double? PersWorkListWorkDays { get; set; }
        public int? PersWorkListTimax { get; set; }
        public double? PersWorkListMeritLeave { get; set; }
        public double? PersWorkListRemedialLeave { get; set; }
        public double? PersWorkListTimeLeave { get; set; }
        public double? PersWorkListNoSalaryLeave { get; set; }
        public int? PersWorkingSchdlSi { get; set; }
        public bool? PersWorkListNovice { get; set; }
        public int? PersWorkListAbsence { get; set; }
        public int? PersWorkListHolidays { get; set; }
        public int? PersWorkListShiftNumber { get; set; }
        public int PerPyrlPeriodSi { get; set; }
        public int? CtbCostSi { get; set; }
        public double? PersWorkListMission { get; set; }
        public double? PersWorkListIncrgOverTime { get; set; }
        public bool? PersWorkListCalc { get; set; }
        public short? PersWorkListShiftType { get; set; }
        public bool? PersWorkListOffReplace { get; set; }
        public int? PersWorkListShiftNum2 { get; set; }
        public short? PersWorkListShiftTyp2 { get; set; }
    }
}

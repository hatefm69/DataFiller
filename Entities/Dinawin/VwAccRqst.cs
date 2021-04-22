using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAccRqst : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AccArqstCu { get; set; }
        public DateTime AccArqstDt { get; set; }
        public int? AccRqstTypSi { get; set; }
        public int? AccRqstStsSi { get; set; }
        public string AccRqstStsTp { get; set; }
        public string AccRqstTypTp { get; set; }
        public double? AccArqstPrc { get; set; }
        public string AccArqstDesc { get; set; }
        public string CuCost { get; set; }
        public string TpCost { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public string CuProject { get; set; }
        public string TpProject { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public int AccArqstSi { get; set; }
        public double? AccBudgetPrc { get; set; }
        public int? AccBudgetSi { get; set; }
        public double? PrcRqst { get; set; }
        public double RemainPrc { get; set; }
        public DateTime? AccBudgetFromDs { get; set; }
        public DateTime? AccBudgetToDs { get; set; }
        public string AccBudgetTp { get; set; }
        public string AccBudgetCu { get; set; }
        public decimal? SumAcc { get; set; }
        public double? RemainAcc { get; set; }
        public int? AccLkSi { get; set; }
        public int? AccLmSi { get; set; }
        public int? AccLtSi { get; set; }
        public int? AccLpSi { get; set; }
        public int? AccLcSi { get; set; }
        public double? AccBudgetPrcCredit { get; set; }
        public double? AccBudgetPrcCost { get; set; }
    }
}

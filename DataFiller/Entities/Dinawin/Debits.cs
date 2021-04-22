using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Debits : DinawinBaseEntity, IMyEntityDinawin
    {
        public string SystemName { get; set; }
        public string ShDate { get; set; }
        public string Description { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public int? Si { get; set; }
        public string Typ { get; set; }
        public string SalcustSi { get; set; }
        public string SalcustCu { get; set; }
        public string SalcustTp { get; set; }
        public int Id { get; set; }
    }
}

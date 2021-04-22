using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Table11 : DinawinBaseEntity, IMyEntityDinawin
    {
        public string Rcid { get; set; }
        public string Itemid { get; set; }
        public int? Qty { get; set; }
        public string Input { get; set; }
        public DateTime? Date { get; set; }
    }
}

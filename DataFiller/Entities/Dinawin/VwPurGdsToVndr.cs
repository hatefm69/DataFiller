using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPurGdsToVndr: DinawinBaseEntity, IMyEntityDinawin
    {
        public int InvGdsSi { get; set; }
        public string InvGdsCu { get; set; }
        public string InvGdsTp { get; set; }
        public string PurGdsGrpCu { get; set; }
        public string PurGdsGrpTp { get; set; }
        public int? PurVndrSi { get; set; }
        public int PurGdsToVndrSi { get; set; }
    }
}

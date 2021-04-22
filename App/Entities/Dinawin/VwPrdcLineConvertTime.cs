using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwPrdcLineConvertTime: DinawinBaseEntity, IMyEntityDinawin
    {
        public int? PrdcLineTitleSi { get; set; }
        public int? PrdcLineMt { get; set; }
        public int? PrdcLineHt { get; set; }
    }
}

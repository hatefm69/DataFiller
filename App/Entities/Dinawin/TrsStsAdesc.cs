using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class TrsStsAdesc : DinawinBaseEntity, IMyEntityDinawin
    {
        public string TrsStsAdescSi { get; set; }
        public string TrsStsAdescFieldName { get; set; }
        public string TrsStsAdescDesc { get; set; }
    }
}

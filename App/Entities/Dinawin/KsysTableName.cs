using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class KsysTableName : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TabId { get; set; }
        public string Tabname { get; set; }
        public bool? TabSys { get; set; }
        public int? TabOrder { get; set; }
    }
}

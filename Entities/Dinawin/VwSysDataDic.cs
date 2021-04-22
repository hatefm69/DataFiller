using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwSysDataDic : DinawinBaseEntity, IMyEntityDinawin
    {
        public string CName { get; set; }
        public string Xtype { get; set; }
        public string OName { get; set; }
    }
}

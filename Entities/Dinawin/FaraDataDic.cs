using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraDataDic : DinawinBaseEntity, IMyEntityDinawin
    {
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string Fa { get; set; }
        public string En { get; set; }
        public string Ar { get; set; }
        public string Gr { get; set; }
    }
}

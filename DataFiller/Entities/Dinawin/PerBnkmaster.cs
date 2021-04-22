using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerBnkmaster : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PerBnkmasterSi { get; set; }
        public string PerBnkmasterTp { get; set; }
        public string PerBnkmasterAccountNo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PmEquip : DinawinBaseEntity, IMyEntityDinawin
    {
        public int PmAccessEquipId { get; set; }
        public string PmAccessEquipCode { get; set; }
        public string PmAccessEquipDesc { get; set; }
    }
}

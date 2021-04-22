using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssMachine : DinawinBaseEntity, IMyEntityDinawin
    {
        public AssMachine()
        {
            AssMachinId = new HashSet<AssMachinId>();
            AssMachineModel = new HashSet<AssMachineModel>();
            AssReception = new HashSet<AssReception>();
        }

        public int AssMachineSi { get; set; }
        public string AssMachineCu { get; set; }
        public string AssMachineTp { get; set; }
        public string AssMachineSerial { get; set; }
        public DateTime? AssMachineDate { get; set; }

        public virtual ICollection<AssMachinId> AssMachinId { get; set; }
        public virtual ICollection<AssMachineModel> AssMachineModel { get; set; }
        public virtual ICollection<AssReception> AssReception { get; set; }
    }
}

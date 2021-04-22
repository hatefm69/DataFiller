using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssMission : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssMissionSi { get; set; }
        public string AssMissionCu { get; set; }
        public DateTime? AssMissionDate { get; set; }
        public int? AssReceptionSi { get; set; }
        public int? AssPrsSi { get; set; }
        public string AssMissionVehicle { get; set; }
        public string AssMissionNote { get; set; }
        public string AssMissionDeparture1 { get; set; }
        public string AssMissionPurpose1 { get; set; }
        public string AssMissionDeparture2 { get; set; }
        public string AssMissionPurpose2 { get; set; }
        public string AssMissionDeparture3 { get; set; }
        public string AssMissionPurpose3 { get; set; }
        public byte? AssMissionDuring { get; set; }
    }
}

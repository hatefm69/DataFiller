using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAssServiceH : DinawinBaseEntity, IMyEntityDinawin
    {
        public int AssSrvHSi { get; set; }
        public string AssSrvHCu { get; set; }
        public DateTime? AssSrvHDate { get; set; }
        public string AssSrvHDeliverer { get; set; }
        public string AssSrvHWrong { get; set; }
        public string AssSrvHAction { get; set; }
        public string AssSrvHNote { get; set; }
        public int? AssPrsSi { get; set; }
        public int? AssReceptionSi { get; set; }
        public bool? AssSrvHOview { get; set; }
        public bool? AssSrvHLReq { get; set; }
        public bool? AssSrvHInstall { get; set; }
        public bool? AssSrvHEduc { get; set; }
    }
}

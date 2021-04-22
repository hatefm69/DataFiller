using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AssReception : DinawinBaseEntity, IMyEntityDinawin
    {
        public AssReception()
        {
            AssReceptionD = new HashSet<AssReceptionD>();
            AssServiceH = new HashSet<AssServiceH>();
        }

        public int AssReceptionSi { get; set; }
        public string AssReceptionCu { get; set; }
        public int? AssReceptionStatusSi { get; set; }
        public int? AssReceptionKindSi { get; set; }
        public DateTime? AssReceptionDate { get; set; }
        public int AssCustSi { get; set; }
        public int? AssPrsSi { get; set; }
        public int? AssMachineSi { get; set; }
        public int? AssMachineModelSi { get; set; }
        public string AssReceptionLetterNo { get; set; }
        public string AssReceptionDeliverer { get; set; }
        public string AssReceptionAppendix { get; set; }
        public string AssReceptionDescription { get; set; }
        public string AssMachineSerial { get; set; }
        public string AssReceptionPackNo { get; set; }
        public bool? AssReceptionFinalize { get; set; }
        public bool? AssReceptionLock { get; set; }

        public virtual AssCust AssCustSiNavigation { get; set; }
        public virtual AssMachineModel AssMachineModelSiNavigation { get; set; }
        public virtual AssMachine AssMachineSiNavigation { get; set; }
        public virtual AssPersonel AssPrsSiNavigation { get; set; }
        public virtual ICollection<AssReceptionD> AssReceptionD { get; set; }
        public virtual ICollection<AssServiceH> AssServiceH { get; set; }
    }
}

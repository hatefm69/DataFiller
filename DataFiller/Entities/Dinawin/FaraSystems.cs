using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraSystems : DinawinBaseEntity, IMyEntityDinawin
    {
        public FaraSystems()
        {
            AccHdoc = new HashSet<AccHdoc>();
            FaraVerHistory = new HashSet<FaraVerHistory>();
            TrsArqst = new HashSet<TrsArqst>();
        }

        public int SiSystem { get; set; }
        public string TpSystem { get; set; }

        public virtual ICollection<AccHdoc> AccHdoc { get; set; }
        public virtual ICollection<FaraVerHistory> FaraVerHistory { get; set; }
        public virtual ICollection<TrsArqst> TrsArqst { get; set; }
    }
}

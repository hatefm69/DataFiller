using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccCtbMinfo : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccCtbMinfo()
        {
            AccCtbMinfoValue = new HashSet<AccCtbMinfoValue>();
        }

        public int AccCtbMinfoSi { get; set; }
        public int? SiAccM { get; set; }
        public string AccCtbMinfoTp { get; set; }
        public bool? IsInput { get; set; }
        public int? AccCtbMinfoType { get; set; }
        public int? AccCtbMinfoCompanySi { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsUnique { get; set; }

        public virtual AccCtbMinfoCompany AccCtbMinfoCompanySiNavigation { get; set; }
        public virtual CtbAccM SiAccMNavigation { get; set; }
        public virtual ICollection<AccCtbMinfoValue> AccCtbMinfoValue { get; set; }
    }
}

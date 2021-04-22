using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AccCtbMinfoCompany : DinawinBaseEntity, IMyEntityDinawin
    {
        public AccCtbMinfoCompany()
        {
            AccCtbMinfo = new HashSet<AccCtbMinfo>();
        }

        public int AccCtbMinfoCompanySi { get; set; }
        public string CompanyName { get; set; }

        public virtual ICollection<AccCtbMinfo> AccCtbMinfo { get; set; }
    }
}

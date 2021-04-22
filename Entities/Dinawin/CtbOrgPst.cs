using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class CtbOrgPst : DinawinBaseEntity, IMyEntityDinawin
    {
        public CtbOrgPst()
        {
            PerCmd = new HashSet<PerCmd>();
        }

        public int CtbOrgPstSi { get; set; }
        public string CtbOrgPstCu { get; set; }
        public string CtbOrgPstTp { get; set; }
        public int CtbOrgPstSiParent { get; set; }
        public int CtbOrgJobSi { get; set; }
        public int CtbOrgDepSi { get; set; }
        public short? CtbOrgPstPrmt { get; set; }
        public short? CtbOrgPstAsgn { get; set; }

        public virtual CtbOrgDep CtbOrgDepSiNavigation { get; set; }
        public virtual CtbOrgJob CtbOrgJobSiNavigation { get; set; }
        public virtual ICollection<PerCmd> PerCmd { get; set; }
    }
}

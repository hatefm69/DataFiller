using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwCtbOrgPst : DinawinBaseEntity, IMyEntityDinawin
    {
        public int CtbOrgPstSi { get; set; }
        public string CtbOrgPstCu { get; set; }
        public string CtbOrgPstTp { get; set; }
        public int CtbOrgJobSi { get; set; }
        public int CtbOrgDepSi { get; set; }
        public short? CtbOrgPstPrmt { get; set; }
        public short? CtbOrgPstAsgn { get; set; }
        public string CtbOrgJobCu { get; set; }
        public string CtbOrgJobTp { get; set; }
        public string CtbOrgDepCu { get; set; }
        public string CtbOrgDepTp { get; set; }
        public short? CtbOrgDepLvl { get; set; }
    }
}

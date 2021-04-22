using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PerPrsnl : DinawinBaseEntity, IMyEntityDinawin
    {
        public PerPrsnl()
        {
            AstAsset = new HashSet<AstAsset>();
            PerAdv = new HashSet<PerAdv>();
            PerCmd = new HashSet<PerCmd>();
            PerIncDec = new HashSet<PerIncDec>();
            PerLoans = new HashSet<PerLoans>();
            PerPrsnlAttach = new HashSet<PerPrsnlAttach>();
            PerWrkLst = new HashSet<PerWrkLst>();
        }

        public int PerPrsnlSi { get; set; }
        public string PerPrsnlCu { get; set; }
        public string PerPrsnlTp { get; set; }
        public string PerPrsnlFname { get; set; }
        public string PerPrsnlLname { get; set; }
        public bool PerPrsnlAct { get; set; }
        public int? CtbOrgPstSi { get; set; }
        public int? CtbOrgDepSi { get; set; }
        public int? CtbOrgJobSi { get; set; }

        public virtual ICollection<AstAsset> AstAsset { get; set; }
        public virtual ICollection<PerAdv> PerAdv { get; set; }
        public virtual ICollection<PerCmd> PerCmd { get; set; }
        public virtual ICollection<PerIncDec> PerIncDec { get; set; }
        public virtual ICollection<PerLoans> PerLoans { get; set; }
        public virtual ICollection<PerPrsnlAttach> PerPrsnlAttach { get; set; }
        public virtual ICollection<PerWrkLst> PerWrkLst { get; set; }
    }
}

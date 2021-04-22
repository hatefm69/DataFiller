using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurVndr : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurVndr()
        {
            AstAsset = new HashSet<AstAsset>();
            InvDocH = new HashSet<InvDocH>();
            PurEnqry = new HashSet<PurEnqry>();
            PurInvcH = new HashSet<PurInvcH>();
            PurOrdr = new HashSet<PurOrdr>();
        }

        public int PurVndrSi { get; set; }
        public string PurVndrCu { get; set; }
        public string PurVndrTp { get; set; }
        public string PurVndrDocno { get; set; }
        public int? PurVndrScore { get; set; }
        public byte? PurVndrKind { get; set; }
        public byte? PurVndrSts { get; set; }
        public string PurVndrComment { get; set; }
        public int? PurVndrGrpSi { get; set; }
        public int? AccMSi1 { get; set; }
        public int? AccTSi { get; set; }
        public short? PurVndrCorporateTyp { get; set; }
        public short? CtbCustVndrTypSi { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }

        public virtual CtbAccM AccMSi1Navigation { get; set; }
        public virtual CtbAccT AccTSiNavigation { get; set; }
        public virtual PurVndrGrp PurVndrGrpSiNavigation { get; set; }
        public virtual ICollection<AstAsset> AstAsset { get; set; }
        public virtual ICollection<InvDocH> InvDocH { get; set; }
        public virtual ICollection<PurEnqry> PurEnqry { get; set; }
        public virtual ICollection<PurInvcH> PurInvcH { get; set; }
        public virtual ICollection<PurOrdr> PurOrdr { get; set; }
    }
}

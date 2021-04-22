using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class AstGrup : DinawinBaseEntity, IMyEntityDinawin
    {
        public AstGrup()
        {
            AstAsset = new HashSet<AstAsset>();
        }

        public string AstGrupId { get; set; }
        public string AstGrupTx { get; set; }
        public byte AstCnsMthdId { get; set; }
        public double? AstGrupDepreciateRate { get; set; }
        public string AccAcntIdDepreciate { get; set; }
        public string AccAcntIdAdepreciate { get; set; }
        public int? AccMSi1 { get; set; }
        public int? AccTSi1 { get; set; }
        public int? AccMSi { get; set; }
        public int? AccTSi { get; set; }
        public int? AstGrupIdParent { get; set; }
        public int? AccMSi2 { get; set; }
        public int? AccTSi2 { get; set; }
        public int? AccLcSi { get; set; }
        public int? AccLpSi { get; set; }
        public int? AccLcSi1 { get; set; }
        public int? AccLpSi1 { get; set; }
        public int? AccLcSi2 { get; set; }
        public int? AccLpSi2 { get; set; }

        public virtual AstCnsMthd AstCnsMthd { get; set; }
        public virtual ICollection<AstAsset> AstAsset { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class PurIncDecFactorType : DinawinBaseEntity, IMyEntityDinawin
    {
        public PurIncDecFactorType()
        {
            PurIncDecFactor = new HashSet<PurIncDecFactor>();
            PurIncDecFactorH = new HashSet<PurIncDecFactorH>();
        }

        public int PurIncDecFactorTypeSi { get; set; }
        public string PurIncDecFactorTypeCu { get; set; }
        public string PurIncDecFactorTypeTp { get; set; }
        public byte? PurIncDecFactorTypeIncDecFlag { get; set; }

        public virtual ICollection<PurIncDecFactor> PurIncDecFactor { get; set; }
        public virtual ICollection<PurIncDecFactorH> PurIncDecFactorH { get; set; }
    }
}

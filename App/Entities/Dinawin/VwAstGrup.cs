using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwAstGrup : DinawinBaseEntity, IMyEntityDinawin
    {
        public string AstCnsMthdTx { get; set; }
        public string AstGrupId { get; set; }
        public string AstGrupTx { get; set; }
        public byte AstCnsMthdId { get; set; }
        public int? AccMSi2 { get; set; }
        public int? AccMSi1 { get; set; }
        public int? AccMSi { get; set; }
        public double? AstGrupDepreciateRate { get; set; }
        public string AccAcntIdDepreciate { get; set; }
        public string AccAcntIdAdepreciate { get; set; }
        public string CuAccM { get; set; }
        public string TpAccM { get; set; }
        public string CuAccM1 { get; set; }
        public string TpAccM1 { get; set; }
        public string CuAccM2 { get; set; }
        public string TpAccM2 { get; set; }
        public int? AccTSi { get; set; }
        public int? AccTSi1 { get; set; }
        public int? AccTSi2 { get; set; }
        public string CuAccT { get; set; }
        public string TpAccT { get; set; }
        public string CuAccT1 { get; set; }
        public string TpAccT1 { get; set; }
        public string CuAccT2 { get; set; }
        public string TpAccT2 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Kolnrf90 : DinawinBaseEntity, IMyEntityDinawin
    {
        public string HsbKol { get; set; }
        public string HsbKolNm { get; set; }
        public string HsbKind { get; set; }
        public string OlvtKol { get; set; }
        public string FarSt { get; set; }
        public string Mahiat { get; set; }
        public string Desbedkol { get; set; }
        public string Desbeskol { get; set; }
        public string KolOld { get; set; }
    }
}

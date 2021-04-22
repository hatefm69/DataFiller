using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraDbver : DinawinBaseEntity, IMyEntityDinawin
    {
        public byte? Major { get; set; }
        public byte? Minor { get; set; }
        public byte? Release { get; set; }
        public byte? Build { get; set; }
    }
}

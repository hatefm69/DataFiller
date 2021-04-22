using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Sysproperties : DinawinBaseEntity, IMyEntityDinawin
    {
        public int? Type { get; set; }
        public int Id { get; set; }
        public int MinorId { get; set; }
        public string Name { get; set; }
        public object Value { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class Dtproperties : DinawinBaseEntity, IMyEntityDinawin
    {
        public int Id { get; set; }
        public int? Objectid { get; set; }
        public string Property { get; set; }
        public string Value { get; set; }
        public byte[] Lvalue { get; set; }
        public int Version { get; set; }
        public string Uvalue { get; set; }
    }
}

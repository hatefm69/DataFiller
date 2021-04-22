using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraInternalLog : DinawinBaseEntity, IMyEntityDinawin
    {
        public Guid Guid { get; set; }
        public DateTime Date { get; set; }
        public string Action { get; set; }
        public string UserName { get; set; }
        public string TableName { get; set; }
        public string KeyValue { get; set; }
        public string DescriptionValue { get; set; }
        public string NumberValue { get; set; }
    }
}

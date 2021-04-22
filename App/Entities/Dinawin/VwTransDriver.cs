using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class VwTransDriver : DinawinBaseEntity, IMyEntityDinawin
    {
        public int TransDriverSi { get; set; }
        public string TransDriverFname { get; set; }
        public string TransDriverLname { get; set; }
        public string TransDriverCarTag { get; set; }
        public string TransDriverFullName { get; set; }
        public string TransDriverTel { get; set; }
        public string TransDriverAddress { get; set; }
    }
}

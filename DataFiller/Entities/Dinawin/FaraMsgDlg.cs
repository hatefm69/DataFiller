using System;
using System.Collections.Generic;

namespace Entities.Dinawin
{
    public partial class FaraMsgDlg : DinawinBaseEntity, IMyEntityDinawin
    {
        public string FormName { get; set; }
        public string Key { get; set; }
        public string Fa { get; set; }
        public string En { get; set; }
    }
}

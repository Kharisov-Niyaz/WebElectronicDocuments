using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class ControlUserGroups
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public bool? GroupIsShow { get; set; }
        public string GroupIsCash { get; set; }
    }
}

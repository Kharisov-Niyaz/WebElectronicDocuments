using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class ControlUsers
    {
        public int ControlUserId { get; set; }
        public string ControlUserName { get; set; }
        public string ControlUserIp { get; set; }
        public int? ControlUserSortNumb { get; set; }
        public int? ControlUserGroup { get; set; }
        public string ControlUserGroupRole { get; set; }
        public string ControlUserNameOnPc { get; set; }
        public bool? ControlUserIsActive { get; set; }
        public bool? ControlUserIsMaternity { get; set; }
        public int ControlUserStageId { get; set; }
        public string ControlUserEmail { get; set; }
        public string ControlUserPassword { get; set; }
    }
}

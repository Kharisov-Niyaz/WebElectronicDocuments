using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserIp { get; set; }
        public DateTime? LastLogin { get; set; }
        public int? OnOff { get; set; }
        public int? OnOffPodskazka { get; set; }
        public bool? UserCashboxAccess { get; set; }
    }
}

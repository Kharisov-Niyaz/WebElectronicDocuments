using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Contacts
    {
        public int ContactId { get; set; }
        public int? CustomerId { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactFax { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNote { get; set; }
        public string MobilePhone { get; set; }
        public string NumberContract { get; set; }
        public string ContactNameStatus { get; set; }
        public int? ContactFlagForEmail { get; set; }
        public string ContactSaveIspolnitel { get; set; }
    }
}

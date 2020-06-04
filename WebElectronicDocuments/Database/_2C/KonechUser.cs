using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class KonechUser
    {
        public int KonechUserId { get; set; }
        public string KonechUserName { get; set; }
        public string KonechUserAddress { get; set; }
        public string KonechUserInn { get; set; }
        public string ContractId { get; set; }
        public string KonechUserNumberChet { get; set; }
        public string KonechUserNumberLic { get; set; }
        public string KonechUserModule { get; set; }
        public string KonechUserHistory { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTalk { get; set; }
        public string CustomerAddressPost { get; set; }
        public string CustomerAddressJur { get; set; }
        public string CustomerInn { get; set; }
        public string CustomerKpp { get; set; }
        public string CustomerRs { get; set; }
        public string CustomerBank { get; set; }
        public string CustomerKs { get; set; }
        public string CustomerBik { get; set; }
        public string CustomerOtherInfo { get; set; }
        public string CustomerNote { get; set; }
        public string CustomerAddressFak { get; set; }
        public byte[] UpsizeTs { get; set; }
        public int? CustomerFutureCust { get; set; }
        public string CustomerNameFull { get; set; }
        public string CustomerAddressShfak { get; set; }
        public string CustomerXmlIndex { get; set; }
        public string CustomerXmlCode { get; set; }
        public string CustomerXmlCity { get; set; }
        public string CustomerXmlStreet { get; set; }
        public string CustomerXmlHouse { get; set; }
        public int? CustomerElectroDoc { get; set; }
        public string CustomerElectroDocItem { get; set; }
    }
}

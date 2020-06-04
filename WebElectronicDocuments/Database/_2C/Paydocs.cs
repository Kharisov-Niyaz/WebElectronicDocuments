using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Paydocs
    {
        public int PaydocId { get; set; }
        public int? ContractId { get; set; }
        public string PaydocNumber { get; set; }
        public DateTime? PaydocDate { get; set; }
        public double? PaydocSumm { get; set; }
        public string PaydocNote { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string PaydocDogLevel { get; set; }
        public string PaydocType { get; set; }
    }
}

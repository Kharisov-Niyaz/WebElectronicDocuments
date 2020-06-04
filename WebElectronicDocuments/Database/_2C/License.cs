using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class License
    {
        public int LicId { get; set; }
        public short? LicNumber { get; set; }
        public DateTime? LicDate { get; set; }
        public short? ContractId { get; set; }
        public short? WorkPlaces { get; set; }
        public string WorkPlacesText { get; set; }
        public string ExecutorName { get; set; }
        public string CustomerName { get; set; }
        public string LicNote { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}

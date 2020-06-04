using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class ProcessingOfRecord
    {
        public int ProcessingUserId { get; set; }
        public DateTime ProcessingCreateDate { get; set; }
        public double ProcessingValue { get; set; }
        public int ProcessingType { get; set; }
    }
}

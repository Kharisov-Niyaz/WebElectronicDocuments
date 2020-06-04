using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Signatures
    {
        public int SignatureId { get; set; }
        public int? CustomerId { get; set; }
        public string SignatureName { get; set; }
        public string SignatureBase { get; set; }
        public string SignatureNote { get; set; }
    }
}

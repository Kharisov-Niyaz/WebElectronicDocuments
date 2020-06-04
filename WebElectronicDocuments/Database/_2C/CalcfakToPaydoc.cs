using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class CalcfakToPaydoc
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int CalcfakId { get; set; }
        public string PaydocId { get; set; }
        public int DocType { get; set; }
        public string CalcfakDate { get; set; }
        public string PaydocDate { get; set; }
    }
}

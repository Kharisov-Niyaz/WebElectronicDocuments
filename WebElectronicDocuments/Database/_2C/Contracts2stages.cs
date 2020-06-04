using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Contracts2stages
    {
        public int? ContractId { get; set; }
        public int? StageId { get; set; }
        public string StageName { get; set; }
        public string StageDate { get; set; }
    }
}

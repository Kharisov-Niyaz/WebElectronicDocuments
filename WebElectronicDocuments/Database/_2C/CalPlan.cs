using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class CalPlan
    {
        public int Id { get; set; }
        public int? ContractId { get; set; }
        public string NameOfWork { get; set; }
        public string DateOfWork { get; set; }
        public string SummaOfWork { get; set; }
        public string DocOfWork { get; set; }
        public string NumberOfStages { get; set; }
        public int IncludedOfWork { get; set; }
    }
}

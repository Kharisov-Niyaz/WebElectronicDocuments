using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class RegMailOutput
    {
        public int RegMailId { get; set; }
        public string RegMailDate { get; set; }
        public string RegMailNumber { get; set; }
        public string RegMailCustomer { get; set; }
        public string RegMailText { get; set; }
        public string RegMailExecutor { get; set; }
        public string RegMailStage { get; set; }
        public string RegMailExecType { get; set; }
    }
}

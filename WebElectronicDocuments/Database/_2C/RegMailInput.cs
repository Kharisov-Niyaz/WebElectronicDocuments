using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class RegMailInput
    {
        public int RegMailId { get; set; }
        public string RegMailDate { get; set; }
        public string RegMailNumber { get; set; }
        public string RegMailCustomer { get; set; }
        public string RegMailOutputNumber { get; set; }
        public string RegMailAddress { get; set; }
        public string RegMailExecutor { get; set; }
        public string RegMailStage { get; set; }
        public string RegMailOutputNumberTrue { get; set; }
        public string RegMailExecType { get; set; }
        public string RegMailObtainmentType { get; set; }
    }
}

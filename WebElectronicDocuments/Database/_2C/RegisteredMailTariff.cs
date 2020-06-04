using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class RegisteredMailTariff
    {
        public int RegisteredMailTariffId { get; set; }
        public double RegisteredMailTariffWeight { get; set; }
        public double RegisteredMailTariffPrice { get; set; }
        public int? RegisteredMailTariffType { get; set; }
    }
}

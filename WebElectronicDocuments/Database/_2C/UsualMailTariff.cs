using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class UsualMailTariff
    {
        public int UsualMailTariffId { get; set; }
        public double UsualMailTariffWeight { get; set; }
        public double UsualMailTariffPrice { get; set; }
        public int? UsualMailTariffType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class SupplementaryAgreement
    {
        public int SupplementaryAgreementId { get; set; }
        public DateTime SupplementaryAgreementDate { get; set; }
        public string SupplementaryAgreementNote { get; set; }
        public int ContractId { get; set; }
    }
}

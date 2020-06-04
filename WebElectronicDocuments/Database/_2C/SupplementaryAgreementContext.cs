using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class SupplementaryAgreementContext
    {
        public int SupplementaryAgreementContextId { get; set; }
        public string SupplementaryAgreementContextNumber { get; set; }
        public string SupplementaryAgreementContextText { get; set; }
        public double SupplementaryAgreementContextPrice { get; set; }
        public int SupplementaryAgreementId { get; set; }
    }
}

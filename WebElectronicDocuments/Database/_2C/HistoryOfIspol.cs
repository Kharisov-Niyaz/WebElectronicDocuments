using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class HistoryOfIspol
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }
        public string MessageFrom { get; set; }
        public int? ContractId { get; set; }
    }
}

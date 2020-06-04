using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class CashboxWorkers
    {
        public int CashboxWorkerId { get; set; }
        public DateTime CashboxWorkerCreatedDate { get; set; }
        public int CashboxWorkerItemId { get; set; }
        public double CashboxWorkerSumm { get; set; }
        public int CashboxWorkerType { get; set; }
        public string CashboxWorkerNote { get; set; }
    }
}

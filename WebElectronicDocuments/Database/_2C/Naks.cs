using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Naks
    {
        public int NakId { get; set; }
        public int? ContractId { get; set; }
        public int? ExecutorId { get; set; }
        public int? NakNumber { get; set; }
        public DateTime? NakDate { get; set; }
        public double? NakSumm { get; set; }
        public double? NakNds { get; set; }
        public string NakNote { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string NakPodpisIsp { get; set; }
        public int? NakIsFull { get; set; }
        public double? NakNdsSumm { get; set; }
        public double? NakSummPlusNds { get; set; }
        public string NakIspolnitel { get; set; }
    }
}

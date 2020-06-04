using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Acts
    {
        public int ActId { get; set; }
        public int? ContractId { get; set; }
        public int? ExecutorId { get; set; }
        public int? ActNumber { get; set; }
        public DateTime? ActDate { get; set; }
        public double? ActSumm { get; set; }
        public double? ActNds { get; set; }
        public string ActNote { get; set; }
        public byte[] UpsizeTs { get; set; }
        public int? ActIsFull { get; set; }
        public double? ActNdsSumm { get; set; }
        public double? ActSummPlusNds { get; set; }
        public string ActIspolnitel { get; set; }
    }
}

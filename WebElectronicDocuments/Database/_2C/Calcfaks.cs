using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Calcfaks
    {
        public int CalcfakId { get; set; }
        public int? ContractId { get; set; }
        public int? ExecutorId { get; set; }
        public int? CalcfakNumber { get; set; }
        public DateTime? CalcfakDate { get; set; }
        public double? CalcfakSumm { get; set; }
        public double? CalcfakNds { get; set; }
        public string CalcfakNote { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string CalcfakPodpisIsp { get; set; }
        public int? CalcfakIsFull { get; set; }
        public string CalcfaksShortText { get; set; }
        public double? CalcfaksNdsSumm { get; set; }
        public double? CalcfaksSummPlusNds { get; set; }
    }
}

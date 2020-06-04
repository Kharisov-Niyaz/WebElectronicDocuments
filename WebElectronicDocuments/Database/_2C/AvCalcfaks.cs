using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class AvCalcfaks
    {
        public int AvCalcfakId { get; set; }
        public int ContractId { get; set; }
        public int ExecutorId { get; set; }
        public string AvCalcfakNumber { get; set; }
        public DateTime AvCalcfakDate { get; set; }
        public double AvCalcfakSumm { get; set; }
        public double AvCalcfakNds { get; set; }
        public string AvCalcfakNote { get; set; }
        public string AvCalcfakPodpisIsp { get; set; }
        public double AvCalcfaksNdsSumm { get; set; }
        public double AvCalcfaksSummPlusNds { get; set; }
    }
}

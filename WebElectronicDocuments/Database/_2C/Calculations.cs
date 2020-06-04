using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Calculations
    {
        public int CalculationId { get; set; }
        public int? ContractId { get; set; }
        public int? ExecutorId { get; set; }
        public int? CalculationNumber { get; set; }
        public DateTime? CalculationDate { get; set; }
        public double? CalculationSumm { get; set; }
        public double? CalculationNds { get; set; }
        public string CalculationNote { get; set; }
        public int? CalculationIsFull { get; set; }
        public double? CalculationNdsSumm { get; set; }
        public double? CalculationSummPlusNds { get; set; }
        public int? CalculationIsFact { get; set; }
    }
}

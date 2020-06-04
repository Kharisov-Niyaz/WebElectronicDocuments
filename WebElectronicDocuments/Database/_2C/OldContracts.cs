using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class OldContracts
    {
        public int ContractId { get; set; }
        public int? CustomerId { get; set; }
        public string ContractTalk { get; set; }
        public int? ContractExecutorId { get; set; }
        public string ContractNumber { get; set; }
        public DateTime? ContractDate { get; set; }
        public string ContractWorkType { get; set; }
        public string ContractNote { get; set; }
        public string ContractSumm { get; set; }
        public string ContractNds { get; set; }
        public int? ContractPayType { get; set; }
        public string ContractPayTypeNote { get; set; }
        public string ContractPayTypeNote2 { get; set; }
        public int? ContractPayTypeFactDays { get; set; }
        public int? ContractWorkdone { get; set; }
        public int? ContractPaid { get; set; }
        public string ContractWorkNote { get; set; }
        public string ContractWorkResult { get; set; }
        public int? ContractClosed { get; set; }
        public int? ContractClosedMonth { get; set; }
        public int? ContractClosedYear { get; set; }
        public short? ContractDocsOrigin { get; set; }
        public string ContractIspolnit { get; set; }
        public string ContractCallResults { get; set; }
        public string ContractTechInfo { get; set; }
        public DateTime? ContractSupportRemindDate { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}

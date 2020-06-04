using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class RegDocs
    {
        public int RegId { get; set; }
        public int? RegNumber { get; set; }
        public short? RegDocType { get; set; }
        public DateTime? RegDate { get; set; }
        public short? ContrId { get; set; }
        public string CustName { get; set; }
        public string ExecName { get; set; }
        public string ExecMan { get; set; }
        public string RegNote { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string RegNumberFr { get; set; }
        public string RegIspolnitel { get; set; }
        public string RegPodpisant { get; set; }
        public string RegPredmet { get; set; }
        public string RegExec { get; set; }
    }
}

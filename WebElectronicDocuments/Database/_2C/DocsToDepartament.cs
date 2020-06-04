using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class DocsToDepartament
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public string DocId { get; set; }
        public int DepartamentId { get; set; }
        public string DocDate { get; set; }
    }
}

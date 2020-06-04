using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class DocsToCalplan
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int DocId { get; set; }
        public int CalplanId { get; set; }
        public int DocType { get; set; }
        public string DocDate { get; set; }
    }
}

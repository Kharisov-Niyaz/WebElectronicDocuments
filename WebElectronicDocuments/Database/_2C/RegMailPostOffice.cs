using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class RegMailPostOffice
    {
        public int RegMailPostOfficeId { get; set; }
        public string RegMailPostOfficeAddress { get; set; }
        public string RegMailPostOfficeWeight { get; set; }
        public string RegMailPostOfficePrice { get; set; }
        public int RegMailOutputId { get; set; }
        public int RegMailOutputParentId { get; set; }
    }
}

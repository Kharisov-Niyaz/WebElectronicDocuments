using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class UsualMailPostOffice
    {
        public int UsualMailPostOfficeId { get; set; }
        public string UsualMailPostOfficeWeight { get; set; }
        public string UsualMailPostOfficePrice { get; set; }
        public int UsualMailPostOfficeCount { get; set; }
        public int UsualMailOutputParentId { get; set; }
    }
}

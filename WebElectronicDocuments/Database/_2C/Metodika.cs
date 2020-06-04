using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Metodika
    {
        public int MetodikaId { get; set; }
        public string NameDoc { get; set; }
        public string Ispolnitel { get; set; }
        public string NumberContract { get; set; }
        public string RegNumber { get; set; }
        public int? NumberId { get; set; }
    }
}

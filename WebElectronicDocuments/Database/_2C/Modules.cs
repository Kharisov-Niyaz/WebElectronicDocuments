using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Modules
    {
        public int ModId { get; set; }
        public string ModName { get; set; }
        public string ModFullName { get; set; }
        public string ModSmallName { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}

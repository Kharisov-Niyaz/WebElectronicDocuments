using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class History
    {
        public int Id { get; set; }
        public string UserIp { get; set; }
        public string Message { get; set; }
        public string Colume { get; set; }
    }
}

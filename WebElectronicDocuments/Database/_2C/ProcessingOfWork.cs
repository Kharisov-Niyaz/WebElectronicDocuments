using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class ProcessingOfWork
    {
        public int ProcessingUserId { get; set; }
        public int ProcessingDay { get; set; }
        public int ProcessingStartHour { get; set; }
        public int ProcessingStartMinute { get; set; }
        public int ProcessingEndHour { get; set; }
        public int ProcessingEndMinute { get; set; }
    }
}

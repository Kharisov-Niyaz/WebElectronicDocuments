using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class OutlaysSumm
    {
        public int OutlaySummId { get; set; }
        public int OutlaySummMonth { get; set; }
        public int OutlaySummDepartamentId { get; set; }
        public int OutlaySummOutlayId { get; set; }
        public string OutlaySummValue { get; set; }
    }
}

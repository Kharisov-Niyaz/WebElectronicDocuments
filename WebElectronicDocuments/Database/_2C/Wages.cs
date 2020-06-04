using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Wages
    {
        public int WagesId { get; set; }
        public string WagesName { get; set; }
        public int WagesCount { get; set; }
        public double WagesSal { get; set; }
        public double WagesSum { get; set; }
        public int WagesCalcSmetaId { get; set; }
    }
}

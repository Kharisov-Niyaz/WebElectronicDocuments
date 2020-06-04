using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class CalcSmeta
    {
        public int CalcSmetaId { get; set; }
        public string CalcSmetaZarplata { get; set; }
        public string CalcSmetaStrachVz { get; set; }
        public string CalcSmetaNakRashod { get; set; }
        public string CalcSmetaPribol { get; set; }
        public string CalcSmetaItog { get; set; }
        public string CalcSmetaNds { get; set; }
        public string CalcSmetaItogNds { get; set; }
        public string ContractId { get; set; }
        public int? CalcSmetaRashifrovka { get; set; }
        public string CalcSmetaWorkType { get; set; }
        public string CalcSmetaTrip { get; set; }
        public string CalcSmetaRashifrovkaWages { get; set; }
    }
}

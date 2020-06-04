using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class AdvanStatementUser
    {
        public int AdvanStUserId { get; set; }
        public string AdvanStUserDate { get; set; }
        public string AdvanStUserNumber { get; set; }
        public string AdvanStUserDocName { get; set; }
        public string AdvanStUserSumm { get; set; }
        public string AdvanStUserNds { get; set; }
        public string AdvanStUserSummPlNds { get; set; }
        public int AdvanStUserContractId { get; set; }
        public bool AdvanStUserMove { get; set; }
        public string AdvanStUserName { get; set; }
    }
}

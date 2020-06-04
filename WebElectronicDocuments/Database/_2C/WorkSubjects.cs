using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class WorkSubjects
    {
        public int WorkSubjectId { get; set; }
        public int? WorkTypeId { get; set; }
        public string WorkSubjectName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace WebElectronicDocuments.Database._2C
{
    public partial class Contracts2workSubject
    {
        public int Id { get; set; }
        public int? ContractId { get; set; }
        public int? WorkSubjectId { get; set; }
        public int? SubjectCount { get; set; }
        public int? WorkSubjectIdTechPod { get; set; }
        public int? WorkSubjectTechPod { get; set; }
    }
}

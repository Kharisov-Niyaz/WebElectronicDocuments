using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebElectronicDocuments.Classes
{
    public class DataModel
    {
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public int StageId { get; set; }
            public bool Head { get; set; }
            public int GroupId { get; set; }
        }

        public class Doc
        {
            public int Id { get; set; }
            public string InitiatorName { get; set; }            
            public string Name { get; set; }
            public string Customer { get; set; }
            public string Description { get; set; }
            public string Executor { get; set; }
            public DateTime CreateDate { get; set; }
            public DateTime CloseDate { get; set; }
            public bool Payment { get; set; }            
            public DocAction DocAction { get; set; }
        }

        public class DocAction
        {
            public int Id { get; set; }
            public int DocId { get; set; }
            public int NormalInspectionId { get; set; }
            public int StageId { get; set; }
            public bool Urgency { get; set; }
            public bool Update { get; set; }
            public string FileName { get; set; }
        }

        public class DocJournal
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public string Message { get; set; }
            public int EventType { get; set; }
            public DateTime CreateDate { get; set; }
            public int DocId { get; set; }
        }

        public class DocFile
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Path { get; set; }
            public int DocId { get; set; }
        }

        public class Stage
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Color { get; set; }
        }

        public class UserJournal
        {
            public int Id { get; set; }
            public string Message { get; set; }
            public DateTime CreateDate { get; set; }
            public int UserId { get; set; }
        }
    }
}

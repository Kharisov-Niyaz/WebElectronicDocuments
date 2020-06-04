using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebElectronicDocuments.Classes.DataModel;

namespace WebElectronicDocuments.Classes.Interfaces
{
    public interface IDocJournal
    {
        Task<List<DocJournal>> GetDocJournalsAsync(int docId);
        Task<bool> AddAsync(DocJournal docJournal);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebElectronicDocuments.Classes.DataModel;

namespace WebElectronicDocuments.Classes.Interfaces
{
    public interface IJournal
    {
        Task AddAsync(UserJournal userJournal);
        Task<List<DataModel.UserJournal>> GetUserJournals(int userId);
    }
}

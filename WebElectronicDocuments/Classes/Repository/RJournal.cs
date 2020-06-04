using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebElectronicDocuments.Classes.Interfaces;
using WebElectronicDocuments.Database;

namespace WebElectronicDocuments.Classes.Repository
{
    public class RJournal : IJournal
    {
        private readonly WedContext wedContext;
        public RJournal(WedContext wedContext)
        {
            this.wedContext = wedContext;
        }
        public async Task AddAsync(DataModel.UserJournal userJournal)
        {
            wedContext.Entry(userJournal).State = EntityState.Added;
            await wedContext.SaveChangesAsync();
        }

        public async Task<List<DataModel.UserJournal>> GetUserJournals(int userId)
        {
            return await wedContext.UserJournals.AsQueryable().Where(wr => wr.UserId == userId).ToListAsync();
        }
    }
}

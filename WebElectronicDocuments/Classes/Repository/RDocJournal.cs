using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebElectronicDocuments.Classes.Interfaces;
using WebElectronicDocuments.Database;

namespace WebElectronicDocuments.Classes.Repository
{
    public class RDocJournal : IDocJournal
    {
        private readonly WedContext _context;
        public RDocJournal(WedContext dbContext)
        {
            this._context = dbContext;
        }

        public async Task<bool> AddAsync(DataModel.DocJournal docJournal)
        {
            _context.Entry(docJournal).State = EntityState.Added;
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<List<DataModel.DocJournal>> GetDocJournalsAsync(int docId)
        {
            return await _context.DocJournals.AsQueryable().
                         Where(wr => wr.DocId == docId).
                         OrderBy(or => or.CreateDate).ToListAsync();
        }
    }
}

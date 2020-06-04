using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebElectronicDocuments.Classes.Interfaces;
using WebElectronicDocuments.Database;
using static WebElectronicDocuments.Classes.DataModel;

namespace WebElectronicDocuments.Classes.Repository
{
    public class RStage : IStage
    {
        private readonly WedContext _context;
        public RStage(WedContext dbContext)
        {
            this._context = dbContext;
        }
        public async Task<Dictionary<int, Stage>> GetAsync()
        {
            return await _context.Stages.AsQueryable().
                   ToDictionaryAsync(key => key.Id, value => value);
        }
    }
}

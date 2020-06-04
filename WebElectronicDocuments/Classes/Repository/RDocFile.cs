using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebElectronicDocuments.Classes.Interfaces;
using WebElectronicDocuments.Database;

namespace WebElectronicDocuments.Classes.Repository
{
    public class RDocFile : IDocFile
    {
        private readonly WedContext wedContext;
        public RDocFile(WedContext wedContext)
        {
            this.wedContext = wedContext;
        }
        public async Task AddAsync(DataModel.DocFile docFile)
        {
            wedContext.Entry(docFile).State = EntityState.Added;
            await wedContext.SaveChangesAsync();
        }

        public async Task<DataModel.DocFile> Get(int docId)
        {
            DataModel.DocFile docFile;
            docFile = await wedContext.DocFiles.FindAsync(docId);
            if (docFile == null)
                docFile = new DataModel.DocFile();
            return docFile;
        }
    }
}

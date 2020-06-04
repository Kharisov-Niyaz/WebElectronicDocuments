using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebElectronicDocuments.Classes.DataModel;

namespace WebElectronicDocuments.Classes.Interfaces
{
    public interface IDocFile
    {
        Task AddAsync(DocFile docFile);
        Task<DocFile> Get(int docId);
    }
}

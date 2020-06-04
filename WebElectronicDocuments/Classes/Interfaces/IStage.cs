using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebElectronicDocuments.Classes.DataModel;

namespace WebElectronicDocuments.Classes.Interfaces
{
    public interface IStage
    {
        Task<Dictionary<int, Stage>> GetAsync();
    }
}

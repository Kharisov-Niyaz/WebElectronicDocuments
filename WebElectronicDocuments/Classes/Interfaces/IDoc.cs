using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebElectronicDocuments.Classes.DataModel;

namespace WebElectronicDocuments.Classes.Interfaces
{
    public interface IDoc
    {        
        Task<List<Doc>> GetDocsAsync(int userId, int groupId, bool head, int stageId);
        Task<bool> AddDocActionsAsync(DocAction docAction);
        Task<bool> UpdateStageAsync(int userStage, int docId, int stageId);
        Task<bool> UpdateUrgencyAsync(int docId, bool urgency);
        Task<Tuple<bool, bool>> UpdateNormalInspectionAsync(int docId, int userId);
        Task<bool> UpdateFileAsync(int docId, string fileName);

    }
}

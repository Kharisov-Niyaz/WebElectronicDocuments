using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static WebElectronicDocuments.Classes.DataModel;
using static WebElectronicDocuments.Classes.Utils.Common;

namespace WebElectronicDocuments.Classes.Interfaces
{
    public interface IUser
    {
        Task<User> GetUserAsync(string email, string password);
        Task<ErrorCode> UpdateAsync(User user);
        Task<Dictionary<int, string>> GetHeadUsersAsync(int groupId);
        Task<Dictionary<int, string>> GetAllUsersAsync();
    }
}

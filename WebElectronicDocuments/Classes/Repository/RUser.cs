using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebElectronicDocuments.Classes.Interfaces;
using WebElectronicDocuments.Database._2C;
using static WebElectronicDocuments.Classes.Utils.Common;

namespace WebElectronicDocuments.Classes.Repository
{
    public class RUser : IUser
    {
        private readonly _2cContext _2CContext;

        public RUser(_2cContext _2CContext)
        {
            this._2CContext = _2CContext;
        }
        public async Task<Dictionary<int, string>> GetAllUsersAsync()
        {
            return await _2CContext.ControlUsers.AsQueryable().Where(wr => wr.ControlUserIsActive == true).
                         ToDictionaryAsync(d => d.ControlUserId, d => d.ControlUserName);
        }

        public async Task<Dictionary<int, string>> GetHeadUsersAsync(int groupId)
        {
            return await _2CContext.ControlUsers.AsQueryable().Where(wr => wr.ControlUserGroup == groupId &&
                                                                           wr.ControlUserIsActive == true).
                         ToDictionaryAsync(d => d.ControlUserId, d => d.ControlUserName);
        }

        public async Task<DataModel.User> GetUserAsync(string email, string password)
        {
            ControlUsers controlUser = await _2CContext.ControlUsers.AsQueryable().
                                             FirstOrDefaultAsync(wr => wr.ControlUserEmail == email &&
                                                                       wr.ControlUserPassword == password);
            if (controlUser == null)
                return null;
            return new DataModel.User()
            {
                Id = controlUser.ControlUserId,
                Email = controlUser.ControlUserEmail,
                Password = controlUser.ControlUserPassword,
                Head = true, // controlUser.ControlUserGroupRole == "admin",
                GroupId = controlUser.ControlUserGroup ?? 0,
                Name = controlUser.ControlUserName,
                StageId = controlUser.ControlUserStageId
            };
        }

        public async Task<ErrorCode> UpdateAsync(DataModel.User user)
        {
            bool checkExist = await _2CContext.ControlUsers.AsQueryable().
                              AnyAsync(wr => wr.ControlUserEmail == user.Email &&
                                        wr.ControlUserId != user.Id);
            if (checkExist)
                return ErrorCode.EMAIL_EXIST;

            ControlUsers controlUser = await _2CContext.ControlUsers.AsQueryable().
                                Where(wr => wr.ControlUserId == user.Id).
                                FirstOrDefaultAsync();
            if (controlUser == null)
                return ErrorCode.USER_NOT_FOUND;

            controlUser.ControlUserEmail = user.Email;
            controlUser.ControlUserPassword = user.Password;
            await _2CContext.SaveChangesAsync();

            return ErrorCode.NO_ERROR;
        }
    }
}

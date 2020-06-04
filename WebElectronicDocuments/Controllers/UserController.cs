using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebElectronicDocuments.Classes.Interfaces;
using WebElectronicDocuments.Database;
using static WebElectronicDocuments.Classes.DataModel;
using static WebElectronicDocuments.Classes.Utils.Common;

namespace WebElectronicDocuments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJournal _journal;
        private readonly IUser _user;

        public UserController(IJournal journal, IUser user)
        {
            _journal = journal;
            _user = user;
        }

        [HttpGet]
        [Route("GetAllUserList")]
        public async Task<IActionResult> GetAllUserList()
        {
            bool bSuccess = false;
            Dictionary<int, string> users = new Dictionary<int, string>();
            try
            {
                users = await _user.GetAllUsersAsync();
                bSuccess = true;
            }
            catch { }
            if (bSuccess)
                return Ok(JsonConvert.SerializeObject(users));
            return BadRequest();
        }

        [HttpGet]
        [Route("GetUserList/{groupId}")]
        public async Task<IActionResult> GetUserList(int groupId)
        {
            bool bSuccess = false;
            Dictionary<int, string> users = new Dictionary<int, string>();
            try
            {
                users = await _user.GetHeadUsersAsync(groupId);
                bSuccess = true;
            }
            catch { }
            if (bSuccess)
                return Ok(JsonConvert.SerializeObject(users));
            return BadRequest();
        }

        [HttpGet]
        [Route("GetUserJournalList/{userId}")]
        public async Task<IActionResult> GetUserJournalList(int userId)
        {
            try
            {
                return Ok(await _journal.GetUserJournals(userId));
            }
            catch { }
            return BadRequest();
        }

        [HttpPost]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] User user)
        {
            bool bSuccess = false;
            ErrorCode errorCode = ErrorCode.NO_ERROR;
            try
            {
                errorCode = await _user.UpdateAsync(user);
                bSuccess = errorCode == ErrorCode.NO_ERROR;
            }
            catch { }
            if (bSuccess)
            {
                await _journal.AddAsync(
                    new UserJournal()
                    {
                        Message = $"Изменение профиля",
                        CreateDate = DateTime.Now,
                        UserId = user.Id
                    });
                return Ok(user);
            }
            else
            {
                switch (errorCode)
                {
                    case ErrorCode.SAVE_ERROR:
                        return BadRequest(new { message = "Ошибка при сохранении" });
                    case ErrorCode.USER_NOT_FOUND:
                        return BadRequest(new { message = "Пользователь не найден" });
                    case ErrorCode.EMAIL_EXIST:
                        return BadRequest(new { message = "Такой Email уже существует" });
                    default:
                        return BadRequest();
                }
            }
        }
    }
}
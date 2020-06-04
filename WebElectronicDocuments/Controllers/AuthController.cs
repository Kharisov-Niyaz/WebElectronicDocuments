using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebElectronicDocuments.Classes.Interfaces;
using WebElectronicDocuments.Database;
using static WebElectronicDocuments.Classes.DataModel;

namespace WebElectronicDocuments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUser _user;
        private readonly IJournal _journal;
        public AuthController(IUser user,IJournal journal)
        {
            _user = user;
            _journal = journal;
        }

        [HttpGet("login/{email}/{password}", Name = "Login")]
        public async Task<IActionResult> Login(string Email, string Password)
        {
            bool success = false;
            User user = new User();
            try
            {
                user = await _user.GetUserAsync(
                                 email: Email,
                                 password: Password
                                );
                success = user != null;
            }
            catch { }
            if (success)
            {
                await _journal.AddAsync(
                    new UserJournal() 
                    {
                        Message = $"Вход пользователя", 
                        CreateDate = DateTime.Now, 
                        UserId = user.Id 
                    });
                return Ok(user);
            }
            else if (user == null)
                return BadRequest(new { message = "Пользователь не найден" });
            return BadRequest();
        }

        [HttpPost("logout/{userid}", Name = "Logout")]
        public async Task<IActionResult> Logout(int UserID)
        {
            bool bSuccess = false;
            var LogoutTask = Task.Run(() =>
            {
                bSuccess = true;
            });
            await LogoutTask;
            if (bSuccess)
            {
                await _journal.AddAsync(
                    new UserJournal()
                    {
                        Message = $"Выход пользователя",
                        CreateDate = DateTime.Now,
                        UserId = UserID
                    });
                return Ok(UserID);
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("postdata")]
        public async Task<IActionResult> PostData([FromBody] User user)
        {
            var DataTask = Task.Run(() =>
            {
                user.Name += ": " + DateTime.Now.TimeOfDay;
            });
            await DataTask;
            return Ok(user);
        }

        [HttpGet("islogin/{userid}", Name = "IsLogin")]
        public async Task<IActionResult> IsLogin(int UserID)
        {
            bool bIsLogin = false;
            var IsLoginTask = Task.Run(() => { });
            await IsLoginTask;
            if (bIsLogin)
                return Ok(bIsLogin);
            return BadRequest();
        }

    }
}

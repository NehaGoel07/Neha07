using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TriviaGameLibraryShared;

namespace TriviaGameAPI.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly ILogin _login;
        public LoginController(ILogin login)
        {
            _login = login;
        }

        [HttpPost]
        public IActionResult AdminLogin(LoginModel login)
        {
            try
            {
                IActionResult response = Unauthorized();
                var user = _login.AuthenticateCreds(login);
                if (user != null)
                {
                    var tokenString = _login.GenerateToken(user);
                    response = Ok(new { token = tokenString });
                    return response;
                }
                else
                {
                    response = BadRequest(new { message = "Username and password do not match" });
                    return Ok(response);
                }
            }
            catch
            {
                return Ok();
            }
        }
    }
}

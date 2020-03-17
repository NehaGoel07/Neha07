using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using TokenImplement.Data;
using TokenImplement.Models;
using TokenImplement.Repository;

namespace TokenImplement.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class TokenController : ControllerBase
    
    {
        //private IConfiguration _config;
        private IStudentInformation _studentInformation;
        private IAuthenticateUser _authenticateUser;
        private ITokenGenerator _tokenGenerator;
       
        public TokenController(IAuthenticateUser authenticateUser, IStudentInformation studentInformation, ITokenGenerator tokenGenerator)
        {
           
            _authenticateUser = authenticateUser;
            _studentInformation = studentInformation;
            _tokenGenerator = tokenGenerator;
        }

        /// POST:Login
        /// <summary>
        /// Login method authenticate the user and generates token
        /// </summary>
        /// <param name="login"></param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public IActionResult Login(LoginModel login)
        {
            try
            {
                IActionResult response = Unauthorized();
                var user = _authenticateUser.AuthenticateCreds(login);

                if (user != null)
                {
                    var tokenString = _tokenGenerator.GenerateToken(user);
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

        /// <summary>
        /// Admin accessing all the information 
        /// </summary>
        /// <returns>IActionResult</returns>

        [Authorize(Roles ="admin")]
        [HttpGet]
        public IActionResult GetAdminData()
        {
            
            var data = _studentInformation.GetData();
            return Ok(data); 
        }

        /// <summary>
        /// user accessing data of all the users and not of admin
        /// </summary>
        /// <returns>IActionResult</returns>
        [Authorize(Roles = "user")]
        [HttpGet]
        public IActionResult GetUserData()
        {

            var data = _studentInformation.GetUData();
            return Ok(data);

        }
    }
}
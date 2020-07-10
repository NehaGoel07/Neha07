using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public class Login : ILogin
    {
        UserModel user = null;
        private IConfiguration _config;
        private readonly TriviaGameContext _triviaGameContext; 
        public Login(IConfiguration config, TriviaGameContext triviaGameContext)
        {
            _config = config;
            _triviaGameContext = triviaGameContext;
        }
        public UserModel AuthenticateCreds(LoginModel login)
        {
            var name =  _triviaGameContext.AdminUsers.Where(u => u.Name == login.Name).Select(u => u.Name);
            var pass = _triviaGameContext.AdminUsers.Where(p => p.Password == login.Password).Select(p => p.Password);
            var role = (from r in _triviaGameContext.RoleMaster
                        join a in _triviaGameContext.AdminUsers
                        on r.Id equals a.FK_RoleMasterId
                        where a.Name == login.Name
                        select r.RoleType).ToList();

            if (login.Name == name.FirstOrDefault() && login.Password == pass.FirstOrDefault())
            {
                user = new UserModel { Name = name.FirstOrDefault(), userRoles = role.FirstOrDefault() };
            }

            return user;
        }

        public string GenerateToken(UserModel user)
        {
            var key = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSettings:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim> { new Claim(ClaimTypes.Role, user.userRoles, Guid.NewGuid().ToString()) };

            try
            {
                
                var token = new JwtSecurityToken(_config["JwtSettings:Issuer"],
                  _config["JwtSettings:Issuer"],
                  expires: DateTime.Now.AddMinutes(30),
                  claims: claims,
                  signingCredentials: creds
                  );

                var _token = token.ToString();
                AdminUsers uname = _triviaGameContext.AdminUsers.FirstOrDefault(u => u.Name == user.Name);
                uname.Token = _token;
                uname.TokenModifiedOn = DateTime.Now;
                var res = _triviaGameContext.SaveChanges();
                if (res > 0)
                    return new JwtSecurityTokenHandler().WriteToken(token);

                else
                    return "Unable to save token in db";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TokenImplement.Models;

namespace TokenImplement.Repository
{
    public class TokenGenerator:ITokenGenerator
    {

        private IConfiguration _config;
        public TokenGenerator(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Generates Token 
        /// </summary>
        /// <param name="user"></param>
        /// <returns>string</returns>
        public string GenerateToken(UserModel user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim> { new Claim(ClaimTypes.Role, user.userRoles, Guid.NewGuid().ToString()) };

            try
            {

                var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                  _config["Jwt:Issuer"],
                  expires: DateTime.Now.AddMinutes(30),
                  claims: claims,
                  signingCredentials: creds
                  );
                return new JwtSecurityTokenHandler().WriteToken(token);

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}

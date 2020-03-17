using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TokenImplement.Models;

namespace TokenImplement.Repository
{
    public class AuthenticateUser : IAuthenticateUser
    {

        /// <summary>
        /// AuthenticateCreds authenticates username and password from DB
        /// </summary>
        /// <param name="login"></param>
        /// <returns>UserModel</returns>
        public UserModel AuthenticateCreds(LoginModel login)
        {
            UserModel user = null;
            
            try
            {
                var context = new Models.TokenContext();
                var name = (from l in context.Login
                            where l.UserName == login.Username
                            select l.UserName).ToList();
                var pass = (from l in context.Login
                            where l.Pass == login.Password
                            select l.Pass).ToList();
                var role = (from l in context.Login
                            where l.UserName == login.Username
                            select l.Roles).ToList();

                if (login.Username == name.FirstOrDefault() && login.Password == pass.FirstOrDefault())
                {
                    user = new UserModel { Name = name.FirstOrDefault(), userRoles = role.FirstOrDefault() };
                }

                return user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}

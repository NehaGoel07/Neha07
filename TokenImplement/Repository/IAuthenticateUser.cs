using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokenImplement.Models;

namespace TokenImplement.Repository
{
    public interface IAuthenticateUser
    {
        public UserModel AuthenticateCreds(LoginModel login);
    }
}

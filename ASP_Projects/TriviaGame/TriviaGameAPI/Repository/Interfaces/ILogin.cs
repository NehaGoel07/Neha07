using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public interface ILogin
    {
        public UserModel AuthenticateCreds(LoginModel login);

        public string GenerateToken(UserModel user);
    }
}

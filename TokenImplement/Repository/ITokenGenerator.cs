using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokenImplement.Models;

namespace TokenImplement.Repository
{
    public interface ITokenGenerator
    {
        public string GenerateToken(UserModel user);
    }
}

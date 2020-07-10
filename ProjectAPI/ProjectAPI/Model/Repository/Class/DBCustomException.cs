using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Model.Repository.Class
{
    public class DBCustomException: Exception
    {

        public DBCustomException(string exceptionMessage):base(exceptionMessage)
        {
            Debug.Write(exceptionMessage);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using TokenImplement.Models;

namespace TokenImplement.Data
{
    public interface IStudentInformation
    {
        public List<Login> GetData();

        public List<Login> GetUData();
    }
}

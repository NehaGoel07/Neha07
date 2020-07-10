using BreadCrumb.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreadCrumb.Models
{
    public interface IEmployee
    {
        IEnumerable<TblEmpDetails> GetEmployees();
        Login Authenticate(string username, string password);
    }
}

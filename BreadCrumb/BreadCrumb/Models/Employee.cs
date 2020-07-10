using BreadCrumb.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreadCrumb.Models
{
    public class Employee:IEmployee
    {
        Login userRole = null;
        public Login Authenticate(string username, string password)
        {
            var _employeeContext = new EmployeesContext();
            var userName = _employeeContext.Login.Where(user => user.UserName == username).Select(x=>x.UserName);
            var pass = _employeeContext.Login.Where(pass => pass.Password == password).Select(x=>x.Password);
            var role = _employeeContext.Login.Where(x => x.UserName == username).Select(x => x.Role);
            if(username==userName.FirstOrDefault() && password == pass.FirstOrDefault())
            {
                userRole=new Login { Role = role.FirstOrDefault() };
            }
            return userRole;
        }

        public IEnumerable<TblEmpDetails> GetEmployees()
        {
            var _employeeContext = new EmployeesContext();
            var employeeDetails =  _employeeContext.TblEmpDetails.ToList();
            return employeeDetails;
        }
    }
}

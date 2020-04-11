using MVCAdvance.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAdvance.Models.Repository
{
    public interface ILogin
    {
        bool AuthenticateCreds(LoginDetail loginDetail);
        List<TBL_Employees> ShowData();

        List<Employee> Show();
        Employee Detail(int id);
    }
}
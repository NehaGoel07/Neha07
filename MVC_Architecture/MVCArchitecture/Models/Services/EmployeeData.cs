using MVCArchitecture.Models.EntityModel;
using MVCArchitecture.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCArchitecture.Models.Services
{
    public class EmployeeData:IEmployeeData
    {
        public List<TBL_Employees> Data()
        {
            BootCamp2020Entities bootCamp = new BootCamp2020Entities();
            var data=bootCamp.TBL_Employees.ToList();
            return data;
        }
    }
}
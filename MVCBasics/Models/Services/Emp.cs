using MVCBasics.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasics.Models.Services
{
    public class Emp:IEmployee
    {
        public List<TBL_Employees> Data()
        {
            BootCamp2020Entities bootCamp = new BootCamp2020Entities();
            var data = bootCamp.TBL_Employees.ToList();
            return data;
        }

        public bool EditData(TBL_Employees tBL_Employees)
        {
            BootCamp2020Entities bootCamp = new BootCamp2020Entities();
            TBL_Employees row = bootCamp.TBL_Employees.Where(x => x.emp_id == tBL_Employees.emp_id).FirstOrDefault();
            tBL_Employees.emp_salary = bootCamp.TBL_Employees.Single(x => x.emp_id == tBL_Employees.emp_id).emp_salary;
            row.emp_salary = tBL_Employees.emp_salary;
            row.emp_name = tBL_Employees.emp_name;
            row.emp_dob = tBL_Employees.emp_dob;
            row.emp_id = tBL_Employees.emp_id;
            var sc=bootCamp.SaveChanges();
            if(sc>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
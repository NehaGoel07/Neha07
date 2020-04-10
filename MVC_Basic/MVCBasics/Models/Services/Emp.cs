using MVCBasics.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBasics.Models.Services
{
    public class Emp:IEmployee
    {
        /// <summary>
        /// Fetching data from database
        /// </summary>
        /// <returns>List</returns>
        public List<TBL_Employees> Data()
        {
            try
            {
                BootCamp2020Entities bootCamp = new BootCamp2020Entities();
                var data = bootCamp.TBL_Employees.ToList();
                return data;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Updating data of particular employee
        /// </summary>
        /// <param name="tBL_Employees"></param>
        /// <returns>bool</returns>
        public bool EditData(TBL_Employees tBL_Employees)
        {
            try
            {
                BootCamp2020Entities bootCamp = new BootCamp2020Entities();
                TBL_Employees row = bootCamp.TBL_Employees.Where(x => x.emp_id == tBL_Employees.emp_id).FirstOrDefault();
                tBL_Employees.emp_salary = bootCamp.TBL_Employees.Single(x => x.emp_id == tBL_Employees.emp_id).emp_salary;
                row.emp_salary = tBL_Employees.emp_salary;
                row.emp_name = tBL_Employees.emp_name;
                row.emp_dob = tBL_Employees.emp_dob;
                row.emp_id = tBL_Employees.emp_id;
                var sc = bootCamp.SaveChanges();
                if (sc > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationAPI.Models
{
    public class Employees
    {
        //properties for the fields of table in database to retrieve and set values 
        public string Emp_name { get; set; }

        public string Emp_dob { get; set; }

        public string Emp_salary { get; set; }

        public string Manager_id { get; set; }

        public bool IsTrainer { get; set; }
    }
}
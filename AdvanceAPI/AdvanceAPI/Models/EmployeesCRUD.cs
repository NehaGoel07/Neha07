using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


namespace AdvanceAPI.Model
{
    public class EmployeesCRUD
    {
        public int Emp_id { get; set; }
        public string Emp_name { get; set; }
        public DateTime Emp_dob { get; set; }
        public string Emp_salary { get; set; }
        public int Manager_id { get; set; }
        public bool IsTrainer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicMenu.Models
{
    public class TblEmpDetails
    {
        [Key]
        public int emp_id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEntity.Models
{
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        [Key]
        public int CustId { get; set; }

        public string CustName { get; set; }
        public long? CustPhone { get; set; }
        public string CustAddress { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

    }
}

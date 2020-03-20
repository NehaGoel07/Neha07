using System;
using System.Collections.Generic;

namespace DBFirstEntity.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustId { get; set; }
        public string CustName { get; set; }
        public long? CustPhone { get; set; }
        public string CustAddress { get; set; }
        public int? NoOfOrders { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}

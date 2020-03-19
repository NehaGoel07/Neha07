using System;
using System.Collections.Generic;

namespace DBFirstEntity.Models
{
    public partial class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }

        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public decimal? ProdPrice { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}

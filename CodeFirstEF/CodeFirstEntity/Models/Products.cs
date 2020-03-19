using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEntity.Models
{
    public class Products
    {
        public Products()
        {
            Orders = new HashSet<Orders>();
        }
        [Key]
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public decimal? ProdPrice { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeFirst.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        public decimal? OrderAmount { get; set; }
        public DateTime? OrderDate { get; set; }

        public int CustId { get; set; }
        public virtual Customer FkCust { get; set; }

        public int ProdId { get; set; }
        public virtual Products FkProd { get; set; }
    }
}
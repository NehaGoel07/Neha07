using System;
using System.Collections.Generic;

namespace DBFirstEntity.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public int? FkCustId { get; set; }
        public int? FkProdId { get; set; }
        public decimal? OrderAmount { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual Customer FkCust { get; set; }
        public virtual Products FkProd { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Point_of_Sales.Models
{
    public partial class Purchase
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? SupplierId { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalPrice { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Supplier? Supplier { get; set; }
    }
}

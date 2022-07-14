using System;
using System.Collections.Generic;

namespace Point_of_Sales.Models
{
    public partial class Sale
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SellerId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public decimal? Discount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual Employee Seller { get; set; } = null!;
    }
}

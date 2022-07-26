using System;
using System.Collections.Generic;

namespace Point_of_Sales.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Number { get; set; }
        public string Address { get; set; } = null!;

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}

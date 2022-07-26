using System;
using System.Collections.Generic;

namespace Point_of_Sales.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Number { get; set; } = null!;

        public virtual ICollection<Sale> Sales { get; set; }
    }
}

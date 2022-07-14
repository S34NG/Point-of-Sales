using System;
using System.Collections.Generic;

namespace Point_of_Sales.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Accounts = new HashSet<Account>();
            Sales = new HashSet<Sale>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string Number { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Position { get; set; } = null!;

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}

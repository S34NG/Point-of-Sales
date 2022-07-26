using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Back_end
{
    public class Sale
    {
        public int Id { get; set; }
        public User? User { get; set; }
        public Customer? Customer { get; set; }
        public double Total_Price { get; set; }
    }
}

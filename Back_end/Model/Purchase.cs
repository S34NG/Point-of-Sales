using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Back_end
{
    public class Purchase
    {
        public int Id { get; set; }
        public User? User { get; set; }
        public Supplier? Supplier { get; set; }
        public double Total_Price { get; set; }
       
    }
}

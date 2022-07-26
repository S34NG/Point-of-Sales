using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Back_end
{
    internal class Stock
    {
        public int Id { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; } = "";

    }
}

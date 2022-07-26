using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Back_end
{
    internal class Purchse_Detail
    {
        public int Id { get; set; }
        public Product? Product { get; set; }
        public Purchase? Purchase { get; set; }
        public int Quantity { get; set; }
        public double Total_Price { get; set; }
        public DateTime DatePurchase { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Model
{
    public class Product
    {
        public int Id { get; set; }
        public Category? Category { get; set; }
        public decimal Cost { get; set; } = 0;
        public decimal Price { get; set; } = 0;
        public string Name { get; set; } = "Unkown";
    }
}

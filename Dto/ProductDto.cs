using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public CategoryDto? Category { get; set; }
        public string Name { get; set; } = "";
        
        public double Sell_Price { get; set; } 
        public double Cost_Price { get; set; }
        public string Unit { get; set; } = "";
    }
}

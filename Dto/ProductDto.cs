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
        public string Name { get; set; }
        public decimal Cost_price { get; set; }
        public decimal Selling_price { get; set; }
        public string Unit { get; set; }
    }
}

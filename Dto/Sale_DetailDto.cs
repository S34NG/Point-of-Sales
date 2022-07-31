using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Dto
{
    public  class Sale_DetailDto
    {
        public int Id { get; set; }
        public ProductDto? Product   { get; set; }
        public SaleDto? SaleDto { get; set; }
        public int Quantity { get; set; }
        public double Total_Price { get; set; }
        public DateTime DateTime { get; set; }
    }
}

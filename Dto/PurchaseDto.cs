using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Dto
{
    public class PurchaseDto
    {
        public int Id { get; set; } 
        public SupplierDto? Supplier { get; set; }
        public UserDto? User { get; set; }
        public double total_price;
    }
}

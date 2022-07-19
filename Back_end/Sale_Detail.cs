﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sales.Back_end
{
    internal class Sale_Detail
    {
        public int Id { get; set; }
        public Product? Product { get; set; }
        public Sale? Sale { get; set; }
        public int Quantity { get; set; }
        public double Total_Price { get; set; }
        public DateTime Date_Sale { get; set; }
    }
}

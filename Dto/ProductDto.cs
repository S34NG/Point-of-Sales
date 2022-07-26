using Point_of_Sales.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Point_of_Sales.Dto
{
    public class ProductDto
    {
        public Product Product { get; set; }
        public ImageSource ImageSource { get; set; }
        public ProductDto(Product product)
        {
            Product = new Product();
            (Product.Id, 
                Product.Category,
                Product.Cost,
                Product.Name,
                Product.Price) = (product.Id,
                product.Category,
                product.Cost,
                product.Name,
                product.Price);
            ImageSource = new BitmapImage(new Uri(product.Image));
        }
    }
}

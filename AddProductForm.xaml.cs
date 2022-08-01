using Point_of_Sales.Back_end;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Point_of_Sales
{
    /// <summary>
    /// Interaction logic for AddProductForm.xaml
    /// </summary>
    public partial class AddProductForm : Window
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
        POSDBContext db = new POSDBContext();
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please Enter Id");
            }
            if (string.IsNullOrEmpty(txtProduct.Text))
            {
                MessageBox.Show("Please Enter Product ");
            }
            if (string.IsNullOrEmpty(txtCost.Text))
            {
                MessageBox.Show("Please Enter Price");
            }
            if (string.IsNullOrEmpty(txtUnit.Text))
            {
                MessageBox.Show("Pleasse Enter Unit ");
            }
            if (string.IsNullOrEmpty(cbbCategory.Text))
            {
                MessageBox.Show("Please Enter Category ");
            }
            Product product = new Product();
            product.Id = int.Parse(txtId.Text);
            product.Name = txtProduct.Text;
            product.Sell_Price = int.Parse(txtCost.Text);
            product.Unit = txtUnit.Text;
            product.Category.Id = db.Categories.Where(p => p.Name == cbbCategory.Text).FirstOrDefault().Id;
            db.Products.Add(product);
            db.SaveChanges();
        }
    }
}

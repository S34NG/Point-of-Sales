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
    /// Interaction logic for UpdateProductForm.xaml
    /// </summary>
    public partial class UpdateProductForm : Window
    {
        public UpdateProductForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        POSDBContext db = new POSDBContext();
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Product product = db.Products.Where(p => p.Id == int.Parse(txtId.Text)).FirstOrDefault();
            if (product != null){
                product.Category.Id = db.Categories.Where(p => p.Name == cbbCategory.Text).FirstOrDefault().Id;
                product.Name = txtName.Text;
                product.Unit = txtUnit.Text;
                product.Sell_Price = int.Parse(txtCost.Text);
                db.SaveChanges();
            }
        }
    }
}

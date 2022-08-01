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
    /// Interaction logic for AddNewProductToStockForm.xaml
    /// </summary>
    public partial class AddNewProductToStockForm : Window
    {
        public AddNewProductToStockForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Please Enter Id");
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please Enter Name ");
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
            if (string.IsNullOrEmpty(txtDate.Text))
            {
                MessageBox.Show("Please enter Date");
            }

        }
    }
}

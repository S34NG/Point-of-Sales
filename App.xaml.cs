using Point_of_Sales.Back_end.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Point_of_Sales
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var LoginForm = new LoginForm();
            var LoginModel = new LoginViewModel();
            LoginForm.DataContext = LoginModel;
          
            LoginForm.Show();
            





        }
    }
}

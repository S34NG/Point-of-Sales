﻿using Point_of_Sales.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

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
            MainWindow window = new MainWindow();
            string path = "Data/customers.xml";
            var viewModel = new MainWindowViewModel(path);
            viewModel.RequestClose += delegate { window.Close(); };
            // Allow all controls in the window to 
            // bind to the ViewModel by setting the 
            // DataContext, which propagates down 
            // the element tree. 
            window.DataContext = viewModel;
            window.Show();
        }
    }
}

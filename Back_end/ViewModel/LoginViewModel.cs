﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Net;

namespace Point_of_Sales.Back_end.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username = "Seang";
        public string Username { get=>_username; set
            {
                _username = value;
                base.OnPropertyChanged(nameof(Username));
            }
        }
        public string Password { get; set; } = "Lyhour";
        private string _errorMessage = "";
        public string ErrorMessage { get=>_errorMessage; set {
                _errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            } }
        private Visibility _isError = Visibility.Hidden;
        public Visibility IsError { get=>_isError; set {
                _isError = value;
                OnPropertyChanged(nameof(IsError));
            } }
        public RelayCommand LoginCommand { get; private set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(DoLogin);
        }
        private void DoLogin(object? obj)
        {
            ForgotPasswordViewModel.Email();
            //ErrorMessage = "";
            IsError = Visibility.Hidden;
            if (obj != null && obj is PasswordBox)
            {
                Password = (obj as PasswordBox)!.Password;
            }
            //logic of login
            var user = DbContext.Users.Where(u => u.Name == Username && u.Password == Password);
            if(user != null && user.Count()>0)
            {
                User = user.First();
                var dashboard = new ViewProductForm();
                dashboard.Show();
                //go to dashboard user or admin
            }
            else
            {
                ErrorMessage = "Invalid Username or Password";
                IsError = Visibility.Visible;
            }
        }
    }
}

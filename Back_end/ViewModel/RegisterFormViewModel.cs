using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Point_of_Sales.Back_end.ViewModel
{
    public class RegisterFormViewModel : ViewModelBase
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public string ConfirmPassword { get; set; } = "";
        public string Email { get; set; } = "";

        public RelayCommand SignUpCommand { get; private set; }

        public RegisterFormViewModel()
        {
            SignUpCommand = new RelayCommand(DoSignUp);
            MessageBox.Show("Register");
        }

        private void DoSignUp(object? obj)
        {
            MessageBox.Show(Username);
            MessageBox.Show(Password);
            MessageBox.Show(ConfirmPassword);
            MessageBox.Show(Email);
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;

namespace Point_of_Sales.Back_end.ViewModel
{
    public class ForgotPasswordViewModel : ViewModelBase
    {
        public static User? currentUser;

        public int pin { get; set; }
        public RelayCommand ResetPwdCommand { get; private set; }

        public ForgotPasswordViewModel()
        {
            ResetPwdCommand = new RelayCommand(DoResetPwd);
        }

        private void DoResetPwd(object? obj)
        {
            MessageBox.Show("Hello");
            if(obj != null && obj is TextBox)
            {
                pin = int.Parse((obj as TextBox)!.Text);

                if (pin == currentUser!.Pin)
                {
                    CreateNewPasswordForm createNewPasswordForm = new CreateNewPasswordForm();
                    createNewPasswordForm.Show();
                }
            }
        }

        private static int RandomPin()
        {
            Random random = new Random();
            return random.Next(10000, 99999);
        }

        

        public static void Email(User? user)
        {
            int ranPin = RandomPin();
            currentUser = user;
            user!.Pin = ranPin;
            try
            {

                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("psarposofficial@gmail.com");
                message.To.Add(new MailAddress(user!.Email));
                MessageBox.Show(user!.Email);
                message.Subject = "Temporary Pin";
                //message.IsBodyHtml = true; //to make message body as html  
                message.Body = String.Format(" Your Verification Pin is: {0}\n This Pin Will Expire in 10mn.", ranPin);
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("psarposofficial@gmail.com", "zzdnfjmyccdkltep");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }

    }
}

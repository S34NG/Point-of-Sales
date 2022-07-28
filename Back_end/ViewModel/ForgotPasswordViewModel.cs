using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Point_of_Sales.Back_end.ViewModel
{
    public class ForgotPasswordViewModel : ViewModelBase
    {
        public POSDBContext db = new POSDBContext();
        private static int RandomPin()
        {
            Random random = new Random();
            return random.Next(10000, 99999);
        }

        public static void Email()
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("psarposofficial@gmail.com");
                message.To.Add(new MailAddress("phengsamnangsp@gmail.com"));
                message.Subject = "Temporary Pin";
                //message.IsBodyHtml = true; //to make message body as html  
                message.Body = String.Format("Your Verification Pin is: {0}\nThis Pin Will Expire in 10mn.", RandomPin());
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

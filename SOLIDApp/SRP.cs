using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDApp
{
    internal class SRP
    {
      public  class Customer
        {
            public void Login(string username, string passwd) { }
            public string Register(string username, string passwd, string email)
            {
                EmailSender emailSender = new EmailSender();
               return emailSender.SendEmail($"{username} Kaydınız alınmıştır...");
            }
        }

       public class EmailSender
        {
            public string SendEmail(string message) {
                return message;
            }
        }
    }
}

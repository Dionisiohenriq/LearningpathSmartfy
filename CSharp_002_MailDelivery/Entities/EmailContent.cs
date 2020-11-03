using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace CSharp_002_MailDelivery.Entities
{
    public class EmailContent
    {
        public string Subject { get; set; }
        public string Message { get; set; }
        public string MailTo { get; set; }

        public void SendMyMail() 
        {
            
            List<string> mailingList = new List<string>();
            mailingList.Add("henriquedionisio.dionisioferre@gmail.com");
            mailingList.Add("eliel.eas@gmail.com");

            EmailService emailService = new EmailService();
            foreach(var mailTo in mailingList)
            {
                emailService.SendEmail("Teste", "teste", mailTo);
            }
        }
    }
}

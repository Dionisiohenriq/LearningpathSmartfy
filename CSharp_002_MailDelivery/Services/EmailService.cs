using CSharp_002_MailDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace CSharp_002_MailDelivery
{
    class EmailService : IEmailService
    {
        SmtpClient companySmtpClient { get; set; }

        public EmailService()
        {
            ConnectSMTP();
        }

        public void ConnectSMTP()
        {
            companySmtpClient = new SmtpClient("in-v3.mailjet.com");
            companySmtpClient.Credentials = new System.Net.NetworkCredential("d0c7be603fe161b5bd7f2b54189c794f","11cf1e2c49789fc302253313bcf716c4");
            companySmtpClient.Port = 587;
            companySmtpClient.EnableSsl = false;
        }

        public bool SendEmail(EmailEntity emailContent)
        {

            //MAILJET
            var Msg = new MailMessage();
            Msg.Body = emailContent.Message;
            Msg.From = new MailAddress("testlearningpath@protonmail.com");
            Msg.Subject = emailContent.Subject;
            List<string> p = new List<string>();

            Msg.To.Add(emailContent.MailTo);

            var Client = new SmtpClient();
            Client.Credentials =
                new NetworkCredential("d0c7be603fe161b5bd7f2b54189c794f", "11cf1e2c49789fc302253313bcf716c4");
            Client.Port = 587;
            Client.Host = "in-v3.mailjet.com";
            Client.EnableSsl = true;
            Client.Send(Msg);


            return true;
        }


    }
}
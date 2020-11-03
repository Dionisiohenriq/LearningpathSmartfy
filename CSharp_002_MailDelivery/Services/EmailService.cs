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
        public bool SendEmail(string v, EmailContent emailContent)
        {
            SmtpClient companySmtpClient { get; set; }
            public EmailService() 
            {
                ConnectSMTP();
            }

            public void ConnectSMTP()
            {
                companySmtpClient = new SmtpClient("in-v3.mailjet.com");
                companySmtpClient.Credentials = new System.Net.NetworkCredential("d0c7be603fe161b5bd7f2b54189c794f", "11cf1e2c49789fc302253313bcf716c4");
                companySmtpClient.Port = 587;
                companySmtpClient.EnableSsl = false;
            }

            try
            {

                //MAILJET
                //var Msg = new MailMessage();
                //Msg.Body = emailContent.Message;
                //Msg.From = new MailAddress("testlearningpath@protonmail.com");
                //Msg.Subject = emailContent.Subject;
                //List<string> p = new List<string>();

                //Msg.To.Add(emailContent.MailTo);

                //var Client = new SmtpClient();
                //Client.Credentials = new NetworkCredential("d0c7be603fe161b5bd7f2b54189c794f", "11cf1e2c49789fc302253313bcf716c4");
                //Client.Port = 587;
                //Client.Host = "in-v3.mailjet.com";
                //Client.EnableSsl = true;
                //Client.Send(Msg);
                

                string from = "testlearningpath@protonmail.com";
                MailAddress ccHenrique = new MailAddress(from, "Henrique");
                MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

                myMail.CC.Add(ccHenrique);

                myMail.Subject = emailContent.Subject;
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                myMail.Body = emailContent.Message;

                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                myMail.IsBodyHtml = true;

                companySmtpClient.Send(myMail);


                }
            catch (Exception)
            {

                return false;
            }

            return true;
        }
    }
}

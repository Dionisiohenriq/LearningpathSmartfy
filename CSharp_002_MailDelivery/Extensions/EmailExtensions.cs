using System.Collections.Generic;
using System.Net.Mail;
using CSharp_002_MailDelivery.Entities;

namespace CSharp_002_MailDelivery.Extensions
{
    public static class EmailExtensions
    {
        public static MailMessage ToMailMessage(this EmailEntity emailEntity)
        {
            var Msg = new MailMessage();
            Msg.Body = emailEntity.Message;
            Msg.From = new MailAddress("testlearningpath@protonmail.com");
            Msg.Subject = emailEntity.Subject;
            Msg.To.Add(emailEntity.MailTo);

            return Msg;
        }

        public static MailMessage ToMailsMessage(this EmailEntity emailEntity,List<string> mailsList)
        {
            var Msg = new MailMessage();
            Msg.Body = emailEntity.Message;
            Msg.From = new MailAddress("testlearningpath@protonmail.com");
            Msg.Subject = emailEntity.Subject;
            Msg.To.Add(emailEntity.MailTo);

            foreach (var mail in mailsList)
            {
                Msg.CC.Add(mail);
            }

            return Msg;
        }
    }
}

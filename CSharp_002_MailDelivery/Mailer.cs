using CSharp_002_MailDelivery.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Web;


namespace CSharp_002_MailDelivery
{
    class Mailer
    {
        static void Main(string [] args) 
        {

            EmailContent emailContent = new EmailContent();
            //Fill emailContent

            IEmailService emailService = new EmailService();
            
            if(emailService.SendEmail(emailContent))
            {
                Console.WriteLine("Emails enviados com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao enviar e-mails!");
            }


        }
    }
}

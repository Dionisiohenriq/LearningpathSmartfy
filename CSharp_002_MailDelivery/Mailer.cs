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

            //Entidade são classes e objetos que SÃO ALGUMA COISA
            EmailEntity emailModel = new EmailEntity();
            emailModel.MailTo = "eliel.eas@gmail.com";
            emailModel.Subject = "Teste123";
            emailModel.Message = "Corpo do Texto";


            //Serviços ou Interface são classes e objetos que FAZEM ALGUMA COISA
            IEmailService emailService = new EmailService();
            
            if(emailService.SendEmail(emailModel))
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
